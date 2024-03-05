using System;
using System.Security.Policy;

namespace ParkPlanner {
    abstract class Vehicle
    {
        public string plateNo;
        public string type;
        public string brand;
        DateTime parkIn;
        public int flagDown;
        public int additional;

        // Constructor
        public Vehicle(string plateNo, string type, string brand, int flagDown, int additional)
        {
            this.plateNo = plateNo;
            this.type = type;
            this.brand = brand;
            this.parkIn = DateTime.Now;
            this.flagDown = flagDown;
            this.additional = additional;
        }

        public void setParkIn(DateTime parkIn)
        {
            this.parkIn = parkIn;
        }
        public DateTime getParkIn()
        {
            return DateTime.Now;
        }
        public override string ToString()
        {
            return $"{plateNo} \t      {GetType().Name}    \t{brand}\t       {parkIn.ToString()}";
        }
        public abstract TimeSpan getTotalDuration();
        public abstract void setParkOut(DateTime parkout);
    }

    class Motorcycle : Vehicle
    {
       
        DateTime parkOut;

        public Motorcycle(string plateNo, string brand) : base(plateNo, "Motorcycle", brand,20,5)
        {
        }

        public override TimeSpan getTotalDuration() => parkOut - getParkIn();


        public override void setParkOut(DateTime parkout) => this.parkOut = parkout;



    }

    class SuvVan : Vehicle
    {
       
        DateTime parkOut;

        public SuvVan(string plateNo, string brand) : base(plateNo, "Suv/Van", brand,40,20)
        {

        }

        public override TimeSpan getTotalDuration() => parkOut - getParkIn();


        public override void setParkOut(DateTime parkout) => this.parkOut = parkout;

    }

    class Sedan : Vehicle
    {
        DateTime parkOut;

        public Sedan(string plateNo, string brand) : base(plateNo, "Sedan", brand,30,15)
        {
        }

        public override TimeSpan getTotalDuration() => parkOut - getParkIn();


        public override void setParkOut(DateTime parkout) => this.parkOut = parkout;

    }
}