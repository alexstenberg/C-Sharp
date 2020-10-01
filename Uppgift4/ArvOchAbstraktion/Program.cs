using System;
using Klasser;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ArvOchAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> VehicleList = new List<Vehicle>();

            bool showMenu = true;
            

            while (showMenu)
            {
                IGarage garage = new Garage();

                Console.Clear();

                Console.WriteLine("\n[1] Skapa nytt fordon.");
                Console.WriteLine("\n[2] Skriv ut alla registrerade fordon.");
                Console.WriteLine("\n[3) Lägg till fordon till verkstaden.");
                Console.WriteLine("\n[4] Ta bort fordon från verkstaden.");
                Console.WriteLine("\n[5] Avsluta programmet.");

                switch (Console.ReadLine())
                {
                    case "1":

                        Console.Clear();

                        Console.WriteLine("\nVad är det för typ av fordon?");
                        Console.Write("\n\nVälj mellan Bil / Motorcykel / Lastbil / Buss: ");
                        var userInput = Console.ReadLine();

                        Console.Clear();

                        if (userInput == "bil".ToLower())
                        {
                            Console.Write("\nMata in bilens modellnamn: ");
                            var userInputModel = Console.ReadLine();

                            Console.Write("\nMata in bilens registreringsnummer: ");
                            var userInputRegNumber = Console.ReadLine();

                            Console.Write("\nMata in bilens miltal: ");
                            float.TryParse(Console.ReadLine(), out float userInputMilage);

                            Console.Write("\nHar bilen dragkrok? J/N: ");
                            var userDrawHook = Console.ReadLine();
                            bool hasDrawHook = true;

                            if (userDrawHook == "j".ToUpper())
                            {
                                hasDrawHook = true;
                            }
                            else if (userDrawHook == "n".ToUpper())
                            {
                                hasDrawHook = false;
                            }
                            else
                            {
                                Console.WriteLine("\nFelaktig inmatning!");
                            }

                            VehicleList.Add(new Car(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, hasDrawHook));
                        }
                        else if (userInput == "motorcykel".ToLower())
                        {
                            Console.Write("\nMata in motorcykelns modellnamn: ");
                            var userInputModel = Console.ReadLine();

                            Console.Write("\nMata in motorcykelns registreringsnummer: ");
                            var userInputRegNumber = Console.ReadLine();

                            Console.Write("\nMata in motorcykelns miltal: ");
                            float.TryParse(Console.ReadLine(), out float userInputMilage);

                            Console.Write("\nMata in motorcykelns max-hastighet: ");
                            int.TryParse(Console.ReadLine(), out int userInputMaxSpeed);

                            VehicleList.Add(new Motorbike(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, userInputMaxSpeed));
                        }
                        else if (userInput == "lastbil".ToLower())
                        {
                            Console.Write("\nMata in lastbilens modellnamn: ");
                            var userInputModel = Console.ReadLine();

                            Console.Write("\nMata in lastbilens registreringsnummer: ");
                            var userInputRegNumber = Console.ReadLine();

                            Console.Write("\nMata in lastbilens miltal: ");
                            float.TryParse(Console.ReadLine(), out float userInputMilage);

                            Console.Write("\nMata in lastbilens maxlast: ");
                            int.TryParse(Console.ReadLine(), out int userInputMaxLoad);

                            VehicleList.Add(new Truck(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, userInputMaxLoad));
                        }
                        else if ( userInput == "buss".ToLower())
                        {
                            Console.Write("\nMata in bussens modellnamn: ");
                            var userInputModel = Console.ReadLine();

                            Console.Write("\nMata in bussens registreringsnummer: ");
                            var userInputRegNumber = Console.ReadLine();

                            Console.Write("\nMata in bussens miltal: ");
                            float.TryParse(Console.ReadLine(), out float userInputMilage);

                            Console.Write("\nMata in max antalet passagerare bussen kan ta: ");
                            int.TryParse(Console.ReadLine(), out int userInputMaxPassengers);

                            VehicleList.Add(new Buss(userInputModel, userInputRegNumber, userInputMilage, DateTime.Now, userInputMaxPassengers));
                        }
                        else
                        {
                            
                        }
                        break;

                    case "2":

                        Console.Clear();

                        //List<Car> bilar = VehicleList.OfType<Car>().ToList();

                        for (int i = 0; i < VehicleList.Count; i++)
                        {
                            if (VehicleList[i] is Car car)
                            {

                                Console.WriteLine("\nRegistrerad bil: ");
                                Console.WriteLine($"\n\n Modell: {car.ModelName} \tMiltal: {car.CarMeter}" +
                                                  $"\n\n Registreringsnummer: {car.RegNumber} \tRegistrerad: {car.RegDate} " +
                                                  $"\tHar dragkok?: {car.HasDrawHook}");
                            }
                            else if (VehicleList[i] is Motorbike motorBike)
                            {
                                Console.WriteLine("\nRegistrerad motorcykel: ");
                                Console.WriteLine($"\n\n Modell: {motorBike.ModelName} \tMiltal: {motorBike.CarMeter}" +
                                                  $"\n\n Registreringsnummer: {motorBike.RegNumber} \tRegistrerad: {motorBike.RegDate} " +
                                                  $"\nMax hastighet: {motorBike.MaxSpeed}");
                            }
                            else if (VehicleList[i] is Truck truck)
                            {
                                Console.WriteLine("\nRegistrerad lastbil: ");
                                Console.WriteLine($"\n\n Modell: {truck.ModelName} \tMiltal: {truck.CarMeter}" +
                                                  $"\n\n Registreringsnummer: {truck.RegNumber} \tRegistrerad: {truck.RegDate} " +
                                                  $"\tMax lastning: {truck.MaxLoad}");
                            }
                            else if (VehicleList[i] is Buss buss)
                            {
                                Console.WriteLine("\nRegistrerad buss: ");
                                Console.WriteLine($"\n\n Modell: {buss.ModelName} \tMiltal: {buss.CarMeter}" +
                                                  $"\n\n Registreringsnummer: {buss.RegNumber} \tRegistrerad: {buss.RegDate} " +
                                                  $"\nMax antalet passagerare: {buss.MaxPassengers}");

                            }

                            Console.WriteLine("\nÅtervänder till menyn");
                            Thread.Sleep(2000);
                            
                        }
                        break;

                    case "3":
                        break;

                    default:

                        showMenu = false;
                        break;

                }

            }
        }
    }
}
