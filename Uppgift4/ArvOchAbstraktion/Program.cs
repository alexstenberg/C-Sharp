using System;
using Klasser;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace ArvOchAbstraktion
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Vehicles> VehicleList = new List<Vehicles>();
            IGarage garage = new Garage();
            
            
            bool showMenu = true;
            

            while (showMenu)
            {

                Console.Clear();
                
                Console.WriteLine("\n[1] Skapa nytt fordon.");
                Console.WriteLine("\n[2] Skriv ut alla registrerade fordon.");
                Console.WriteLine("\n\n[3] Skriv ut alla fordon i verkstaden.");
                Console.WriteLine("\n[4) Lägg till fordon till verkstaden.");
                Console.WriteLine("\n[5] Ta bort fordon från verkstaden.");
                Console.WriteLine("\n[6] Avsluta programmet.");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        
                        Console.Clear();

                        Console.WriteLine("\nVad är det för typ av fordon?");
                        Console.Write("\n\nVälj mellan Bil / Motorcykel / Lastbil / Buss: ");
                        var userInput = Console.ReadLine();

                        Console.Clear();

                        if (userInput == "bil".ToUpper() || userInput == "BIL".ToLower() || userInput == "Bil")
                        {
                            Car car = new Car();
                            car.CreateVehicle(VehicleList, car);
                            
                        }
                        else if (userInput == "motorcykel".ToLower())
                        {
                            Motorbike motorbike = new Motorbike();
                            motorbike.CreateVehicle(VehicleList, motorbike);
                        }
                        else if (userInput == "Lastbil".ToUpper())
                        {
                            Truck truck = new Truck();
                            truck.CreateVehicle(VehicleList, truck);

                        }
                        else if ( userInput == "buss".ToLower())
                        {
                            Buss buss = new Buss();
                            buss.CreateVehicle(VehicleList, buss);

                        }
                        else
                        {
                            Console.WriteLine("\n\nFelaktig inmatning. Försök igen!");
                        }

                        Console.WriteLine("\n\nTryck på valfri knapp för att återgå till menyn.");
                        Console.ReadLine();

                        break;

                    case "2":

                        Console.Clear();
                        VehicleHelper.PrintVehicles(VehicleList);
                        
                        Console.WriteLine("\nTryck på valfri knapp för att återgå till menyn.");
                        Console.ReadLine();

                        break;

                    case "3":

                        Console.Clear();
                        garage.PrintVehiclesInGarage();
                        Console.WriteLine("\nTryck på valfri knapp för att återgå till menyn.");
                        Console.ReadLine();

                        break;

                    case "4":

                        Console.Clear();

                        garage.AddVehicleToGarage(ref VehicleList);
                        Console.WriteLine("\nTryck på valfri knapp för att återgå till menyn.");
                        Console.ReadLine();

                        break;

                    case "5":

                        Console.Clear();

                        garage.RemoveVehicleFromGarage(ref VehicleList);
                        Console.WriteLine("\nTryck på valfri knapp för att återgå till menyn.");
                        Console.ReadLine();

                        break;

                    case "6":

                        showMenu = false;
                        break;

                    default:

                        showMenu = true;
                        break;

                }

            }
        }
    }
}
