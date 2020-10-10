using System;
using System.Collections.Generic;
using Klasser;


namespace Klasser
{
    public abstract class Vehicles
    {
        public string ModelName { get; set; }
        public string RegNumber { get; set; }
        public float CarMeter { get; set; }
        public DateTime RegDate { get; set; }

        public Vehicles()
        {

        }

        public abstract void CreateVehicle(List<Vehicles> VehicleList, Vehicles vehicle);

    }

    public class Car : Vehicles
    {
        public bool HasDrawHook { get; set; }

        public Car()
        {

        }

        public Car(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, bool HasDrawHook)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.HasDrawHook = HasDrawHook;
        }
        #region CreateVehicle Car - Metod för att skapa en ny bil.
        public override void CreateVehicle(List<Vehicles> VehicleList, Vehicles vehicle)
        {
            Console.Write("\nMata in bilens modellnamn: ");
            var userInputModel = Console.ReadLine();

            Console.Write("\nMata in bilens registreringsnummer: ");
            var userInputRegNumber = Console.ReadLine();

            Console.Write("\nMata in bilens miltal: ");
            float.TryParse(Console.ReadLine(), out float userInputMilage);

            Console.Write("\nHar bilen dragkrok? J/N: ");
            var userDrawHook = Console.ReadLine();
            bool hasDrawHook = false;

            if (userDrawHook.Equals("J", StringComparison.OrdinalIgnoreCase))
            {
                hasDrawHook = true;
            }


            Console.WriteLine("\n\nDu har registrerat en ny bil.");

            VehicleList.Add(new Car(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, hasDrawHook));
            
        }
        #endregion
    }
    public class Motorbike : Vehicles
    {
        public int MaxSpeed { get; set; }

        public Motorbike()
        {

        }

        public Motorbike(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, int MaxSpeed)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.MaxSpeed = MaxSpeed;
        }
        #region CreateVehicle Motorbike - Metod för att skapa en ny motorckyel.
        public override void CreateVehicle(List<Vehicles> VehicleList, Vehicles vehicle)
        {
            Console.Write("\nMata in motorcykelns modellnamn: ");
            var userInputModel = Console.ReadLine();

            Console.Write("\nMata in motorcykelns registreringsnummer: ");
            var userInputRegNumber = Console.ReadLine();

            Console.Write("\nMata in motorcykelns miltal: ");
            float.TryParse(Console.ReadLine(), out float userInputMilage);

            Console.Write("\nMata in motorcykelns max-hastighet: ");
            int.TryParse(Console.ReadLine(), out int userInputMaxSpeed);

            Console.WriteLine("\n\nDu har registrerat en ny motorcykel.");

            VehicleList.Add(new Motorbike(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, userInputMaxSpeed));
            
        }
        #endregion
    }

    public class Truck : Vehicles
    {
        public int MaxLoad { get; set; }

        public Truck()
        {

        }

        public Truck(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, int MaxLoad)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.MaxLoad = MaxLoad;
        }
        #region CreateVehicle Truck - Metod för att skapa en ny lastbil.
        public override void CreateVehicle(List<Vehicles> VehicleList, Vehicles vehicle)
        {
            Console.Write("\nMata in lastbilens modellnamn: ");
            var userInputModel = Console.ReadLine();

            Console.Write("\nMata in lastbilens registreringsnummer: ");
            var userInputRegNumber = Console.ReadLine();

            Console.Write("\nMata in lastbilens miltal: ");
            float.TryParse(Console.ReadLine(), out float userInputMilage);

            Console.Write("\nMata in lastbilens maxlast: ");
            int.TryParse(Console.ReadLine(), out int userInputMaxLoad);

            Console.WriteLine("\n\nDu har registrerat en ny lastbil.");

            VehicleList.Add(new Truck(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, userInputMaxLoad));

        }
        #endregion
    }

    public class Buss : Vehicles
    {
        public int MaxPassengers { get; set; }

        public Buss()
        {

        }

        public Buss(string ModelName, string RegNumber, float CarMeter, DateTime RegDate, int MaxPassengers)
        {
            this.ModelName = ModelName;
            this.RegNumber = RegNumber;
            this.CarMeter = CarMeter;
            this.RegDate = RegDate;
            this.MaxPassengers = MaxPassengers;
        }
        #region CreateVehicle Buss - Metod för att skapa en ny buss.
        public override void CreateVehicle(List<Vehicles> VehicleList, Vehicles vehicle)
        {
            Console.Write("\nMata in bussens modellnamn: ");
            var userInputModel = Console.ReadLine();

            Console.Write("\nMata in bussens registreringsnummer: ");
            var userInputRegNumber = Console.ReadLine();

            Console.Write("\nMata in bussens miltal: ");
            float.TryParse(Console.ReadLine(), out float userInputMilage);

            Console.Write("\nMata in max antalet passagerare bussen kan ta: ");
            int.TryParse(Console.ReadLine(), out int userInputMaxPassengers);

            Console.WriteLine("\n\nDu har registrerat en ny buss.");

            VehicleList.Add(new Buss(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, userInputMaxPassengers));
            
        }
        #endregion
    }

}
