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
            foreach (string brand in motorcyleBrands)
            {
                brandComboBox.Items.Add(brand);
            }
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

        private void parkInButton_Click(object sender, EventArgs e)
        {
            string registration = textBox1.Text;

            if (activeButton == motorButton)
            {
                string brand = brandComboBox.SelectedItem.ToString();
                selectedVehicle = new Motorcycle(registration, brand);
            }
            else if (activeButton == suvButton)
            {
                string brand = brandComboBox.SelectedItem.ToString();
                selectedVehicle = new SuvVan(registration, brand);
            }
            else if (activeButton == sedanButton)
            {
                string brand = brandComboBox.SelectedItem.ToString();
                selectedVehicle = new Sedan(registration, brand);
            }

            // Check if the plate number is unique
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
    }
}