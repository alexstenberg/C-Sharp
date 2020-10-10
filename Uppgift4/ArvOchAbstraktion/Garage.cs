using System;
using System.Collections.Generic;
using System.Text;
using Klasser;
using System.Linq;
using System.Net.Http;

namespace ArvOchAbstraktion
{

    public class Garage : IGarage
    {
        private List<Vehicles> _vehiclesInGarage;
        public List<Vehicles> VehiclesInGarage
        {
            get
            {
                if (_vehiclesInGarage == null)
                {
                    _vehiclesInGarage = new List<Vehicles>();
                }

                return _vehiclesInGarage;
            }

            set
            {
                _vehiclesInGarage = value;
            }

        }


        #region AddVehicleToGarage - Metod för att lägga till ett fordon i garaget.
        public void AddVehicleToGarage(ref List<Vehicles> VehicleList)
        {
            Console.Clear();

            Console.Write("\n\nVilket fordon vill du lägga till i garaget? (Skriv in siffran fordonet är registrerat som): ");
            int.TryParse(Console.ReadLine(), out int userInputWhatVehicle);

            Vehicles whatVehicle = VehicleList[userInputWhatVehicle - 1];

            VehicleList.Remove(whatVehicle);
            VehiclesInGarage.Add(whatVehicle);

            Console.WriteLine("\nFordonet tillagt i garaget.");

        }
        #endregion
        #region RemoveVehicleFromGarage - Metod för att ta bort ett fordon ur garaget.
        public void RemoveVehicleFromGarage(ref List<Vehicles> VehicleList)
        {
            Console.Clear();

            Console.Write("\nVilket fordon vill du ta bort från garaget? (Skriv in siffran fordonet är registrerat som): ");
            int.TryParse(Console.ReadLine(), out int userInputWhatVehicle);

            Vehicles whatVehicle = VehiclesInGarage[userInputWhatVehicle - 1];
            VehiclesInGarage.Remove(whatVehicle);

            Console.WriteLine("\n Fordonet borttaget ur garaget.");


            //for (int i = 0; i < VehiclesInGarage.Count; i++)
            //{
            //    if (VehiclesInGarage.Any(Vehicle => Vehicle.RegNumber == userRemoveVehicle.ToUpper()))
            //    {

            //    }
            //}

            //Console.Write($"\nFordon med registreringsnummer {userRemoveVehicle} är borttaget från garaget.");
        }
        #endregion

        #region PrintVehiclesInGarage - Metod för att skriva ut alla fordon i garaget.
        public void PrintVehiclesInGarage()
        {
            if (VehiclesInGarage.Count == 0)
            {
                Console.WriteLine("\nInga registrerade fordon.");
            }


            Console.WriteLine("\n\nBilar i garaget: ");
            for (int i = 0; i < VehiclesInGarage.Count; i++)
            {

                if (VehiclesInGarage[i] is Car car)
                {
                    Console.WriteLine($"\n\nModell: {car.ModelName} \tRegistreringsnummer: {car.RegNumber}" +
                                      $"\n\nMilmätare {car.CarMeter} \tRegistrerad datum {car.RegDate} \tDragkrok? {car.HasDrawHook}");

                }
            }

            Console.WriteLine("\n\nMotorcyklar i garaget: ");
            for (int i = 0; i < VehiclesInGarage.Count; i++)
            {
                if (VehiclesInGarage[i] is Motorbike motorbike)
                {
                    Console.WriteLine($"\n\nModell: {motorbike.ModelName} \tRegistreringsnummer: {motorbike.RegNumber}" +
                                                     $"\n\nMilmätare {motorbike.CarMeter} \tRegistrerad datum {motorbike.RegDate} " +
                                                      $"\tMax hastighet: {motorbike.MaxSpeed}");

                }
            }

            Console.WriteLine("\n\nLastbilar i garaget: ");
            for (int i = 0; i < VehiclesInGarage.Count; i++)
            {
                if (VehiclesInGarage[i] is Truck truck)
                {
                    Console.WriteLine($"\n\nModell: {truck.ModelName} \tRegistreringsnummer: {truck.RegNumber}" +
                                      $"\n\nMilmätare {truck.CarMeter} \tRegistrerad datum {truck.RegDate} \tMax last: {truck.MaxLoad}");

                }
            }

            Console.WriteLine("\n\nRegistrerade bussar: ");
            for (int i = 0; i < VehiclesInGarage.Count; i++)
            {
                if (VehiclesInGarage[i] is Buss buss)
                {
                    Console.WriteLine($"\n\nModell: {buss.ModelName} \tRegistreringsnummer: {buss.RegNumber}" +
                                      $"\n\nMilmätare {buss.CarMeter} \tRegistrerad datum {buss.RegDate} \tMax passagerare: {buss.MaxPassengers}");

                }
            }
        }
        #endregion
    }
}



