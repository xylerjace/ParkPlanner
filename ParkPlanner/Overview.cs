using ParkPlanner.res;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkPlanner
{
    public partial class Overview : UserControl
    {
        VehicleBrands brands;
        Vehicle selectedVehicle;
        List<string> motorcyleBrands;
        List<string> suvBrands;
        List<string> sedanBrands;
        Button activeButton;
        string type;
        int available = 15;
        int occupied = 0;

        public Overview()
        {
            InitializeComponent();
            brands = new VehicleBrands();
            motorcyleBrands = brands.getMotorcyleBrands();
            suvBrands = brands.getSuvBrands();
            sedanBrands = brands.getSedanBrands();
            activeButton = motorButton; // Set the default active button
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#272438");
        
            availText.Text = available.ToString();
            occupiedText.Text = occupied.ToString();

        }

        private void motorButton_Click(object sender, EventArgs e)
        {
            UpdateBrandComboBox(motorcyleBrands);
            SetActiveButton(sender as Button);
            type = "Motorcyle";
        }

        private void suvButton_Click(object sender, EventArgs e)
        {
            UpdateBrandComboBox(suvBrands);
            SetActiveButton(sender as Button);
            type = "Suv/Van";
        }

        private void sedanButton_Click(object sender, EventArgs e)
        {
            UpdateBrandComboBox(sedanBrands);
            SetActiveButton(sender as Button);
            type = "Sedan";
        }

        private void UpdateBrandComboBox(List<string> brandsList)
        {
            brandComboBox.Items.Clear();
            foreach (string brand in brandsList)
            {
                brandComboBox.Items.Add(brand);
            }
        }

        private void SetActiveButton(Button button)
        {
            // Reset color of previous active button
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(53, 96, 208);
            }

            // Set color of current active button
            activeButton = button;
            activeButton.BackColor = Color.DarkBlue;
        }
        public void setToDefault(Button button)
        {

            activeButton.BackColor = Color.FromArgb(56, 96, 208);
            textBox1.Text = "";
            brandComboBox.Items.Clear();
            brandComboBox.Text = "Select Brand";

        }

        private void parkInButton_Click(object sender, EventArgs e)
        {
            // Check if textBox1 is null or empty
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "")
            {
                MessageBox.Show("Please enter a registration number.");
                return;
            }

            string registration = textBox1.Text;

            if (activeButton == motorButton)
            {
                if (brandComboBox.SelectedItem != null) // Check if brandComboBox.SelectedItem is not null
                {
                    string brand = brandComboBox.SelectedItem.ToString();
                    selectedVehicle = new Motorcycle(registration, brand);
                }
                else
                {
                    MessageBox.Show("Please select a brand.");
                    return;
                }
            }
            else if (activeButton == suvButton)
            {
                if (brandComboBox.SelectedItem != null) // Check if brandComboBox.SelectedItem is not null
                {
                    string brand = brandComboBox.SelectedItem.ToString();
                    selectedVehicle = new SuvVan(registration, brand);
                }
                else
                {
                    MessageBox.Show("Please select a brand.");
                    return;
                }
            }
            else if (activeButton == sedanButton)
            {
                if (brandComboBox.SelectedItem != null) // Check if brandComboBox.SelectedItem is not null
                {
                    string brand = brandComboBox.SelectedItem.ToString();
                    selectedVehicle = new Sedan(registration, brand);
                }
                else
                {
                    MessageBox.Show("Please select a brand.");
                    return;
                }
            }

            bool isUnique = true;
            foreach (Vehicle item in parkoutList.Items)
            {
                if (item.plateNo == selectedVehicle.plateNo)
                {
                    isUnique = false;
                    break;
                }
            }

            if (!isUnique)
            {
                MessageBox.Show("Plate number already exists in the list.");
                return;
            }

            if (parkoutList.Items.Count < 15)
            {
                if (selectedVehicle != null)
                {
                    selectedVehicle.setParkIn(DateTime.Now);
                    parkoutList.Items.Add(selectedVehicle);
                    UpdateOccupied();
                    UpdateAvailable();
                }
            }
            else
            {
                MessageBox.Show("Maximum Capacity Reached!!");
            }
            setToDefault(sender as Button);
        }


        public void UpdateOccupied()
        {
            occupied = parkoutList.Items.Count;
            occupiedText.Text = occupied.ToString();
        }

        public void UpdateAvailable()
        {
            available = 15 - parkoutList.Items.Count;
            availText.Text = available.ToString();
        }

        private void parkoutButton_Click(object sender, EventArgs e)
        {
            if (parkoutList.SelectedIndex != -1)
            {
                selectedVehicle = (Vehicle)parkoutList.SelectedItem;
                DateTime parkIn = selectedVehicle.getParkIn();



                // Remove the selected item from the ListBox
                parkoutList.Items.Remove(selectedVehicle);

                Parkout parkout = new Parkout(selectedVehicle.plateNo, selectedVehicle.brand, selectedVehicle.GetType().Name, selectedVehicle.getParkIn(), selectedVehicle.flagDown, selectedVehicle.additional, this, occupied, available);
                parkout.Show();
            }
            else
            {
                MessageBox.Show("No item selected.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}