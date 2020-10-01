using System;
using System.Collections.Generic;

namespace Klasser
{
    public class Vehicle
    {
        public string ModelName { get; set; }
        public string RegNumber { get; set; }
        public float CarMeter { get; set; }
        public DateTime RegDate { get; set; }

        public List<Vehicle> VehicleList { get; set; }

    }

    public class Car : Vehicle
    {
        public bool HasDrawHook { get; set; }

        public Car(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, bool HasDrawHook)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.HasDrawHook = HasDrawHook;
        }
    }
    public class Motorbike : Vehicle
    {
        public int MaxSpeed { get; set; }

        public Motorbike(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, int MaxSpeed)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.MaxSpeed = MaxSpeed;
        }
    }

    public class Truck : Vehicle
    {
        public int MaxLoad { get; set; }
        public Truck(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, int MaxLoad)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.MaxLoad = MaxLoad;
        }
    }

    public class Buss : Vehicle
    {
        public int MaxPassengers { get; set; }

        public Buss(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, int MaxPassengers)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.MaxPassengers = MaxPassengers;
        }
    }
}
