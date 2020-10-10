using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Klasser
{
    public static class VehicleHelper
    {
        #region PrintVehicles Skriver ut alla registrerade fordon i konsollen.
        public static void PrintVehicles(List<Vehicles> VehicleList)    
        {
            if (VehicleList.Count == 0)
            {
                Console.WriteLine("\nInga registrerade fordon.");
            }


            Console.WriteLine("\n\nRegistrerade bilar: ");
            for (int i = 0; i < VehicleList.Count; i++)
            {

                if (VehicleList[i] is Car car)
                {
                    Console.WriteLine($"\n\nModell: {car.ModelName} \tRegistreringsnummer: {car.RegNumber}" +
                                      $"\n\nMilmätare {car.CarMeter} \tRegistrerad datum {car.RegDate} \tDragkrok? {car.HasDrawHook}");

                }
            }

            Console.WriteLine("\n\nRegistrerade motorcyklar: ");
            for (int i = 0; i < VehicleList.Count; i++)
            {
                if (VehicleList[i] is Motorbike motorbike)
                { 
                    Console.WriteLine($"\n\nModell: {motorbike.ModelName} \tRegistreringsnummer: {motorbike.RegNumber}" +
                                                     $"\n\nMilmätare {motorbike.CarMeter} \tRegistrerad datum {motorbike.RegDate} " +
                                                      $"\tMax hastighet: {motorbike.MaxSpeed}");

                }
            }

            Console.WriteLine("\n\nRegistrerade lastbilar: ");
            for (int i = 0; i < VehicleList.Count; i++)
            {
                if (VehicleList[i] is Truck truck)
                {
                    Console.WriteLine($"\n\nModell: {truck.ModelName} \tRegistreringsnummer: {truck.RegNumber}" +
                                      $"\n\nMilmätare {truck.CarMeter} \tRegistrerad datum {truck.RegDate} \tMax last: {truck.MaxLoad}");

                }
            }

            Console.WriteLine("\n\nRegistrerade bussar: ");
            for (int i = 0; i < VehicleList.Count; i++)
            {
                if (VehicleList[i] is Buss buss)
                {
                    Console.WriteLine($"\n\nModell: {buss.ModelName} \tRegistreringsnummer: {buss.RegNumber}" +
                                      $"\n\nMilmätare {buss.CarMeter} \tRegistrerad datum {buss.RegDate} \tMax passagerare: {buss.MaxPassengers}");

                }
            }
            #endregion


        }
    }
}
