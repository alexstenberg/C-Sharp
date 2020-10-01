using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Car> CarList = new List<Car>();
            List<Person> PersonList = new List<Person>();
            
            int carCount = 0;
            bool showMenu = true;

            while (showMenu)
            {
                /// Skriv ut alternativ i meny
                Console.Clear();
                Console.WriteLine("\n[1] Registrera ny person.");
                Console.WriteLine("\n[2] Skriv ut alla personer.");
                Console.WriteLine("\n[3] Registrera bil på person.");
                Console.WriteLine("\n[4] Skriv ut registrerade personer och deras bilar." );
                Console.WriteLine("\n\n[5] Registrera ny bil.");
                Console.WriteLine("\n[6] Ändra miltal på bil.");
                Console.WriteLine("\n[7] Skriv ut alla registrerade bilar.");
                Console.WriteLine("\n[8] Ta bort alla bilar ur register.");
                Console.WriteLine("\n[9] Avsluta\n");

                // Switch för menyalternativ, tar emot en sträng.
                switch (Console.ReadLine())
                {
                    case "1":

                        Person.CreateNewPerson(PersonList);
                       
                        break;

                    case "2":

                        Console.Clear();

                        for (int i = 0; i < PersonList.Count; i++)
                        {
                            Console.WriteLine($"\n-----Registrerad person nummer: {i + 1}-----");

                            Console.WriteLine($"\nNamn: {PersonList[i].FirstName} \tÅlder: {PersonList[i].Age}");
                            Thread.Sleep(500);
                        }

                        Console.WriteLine("\nTryck på valfri knapp för att återvända till menyn.");
                        Console.ReadLine();

                        break;

                    case "3":

                        Person.AddCarToPerson(PersonList, CarList);
                        
                        break;

                    case "4":

                        Console.Clear();

                        for (int i = 0; i < PersonList.Count; i++)
                        {
                            Person person = PersonList[i];
                            Console.WriteLine($"\n Namn: {person.FirstName} \tÅlder: {person.Age} \n\nÄger följande bilar: ");

                            for (int j = 0; j < person.OwnedCars.Count; j++)
                            {
                                Thread.Sleep(250);
                                Car car = person.OwnedCars[j];
                                Console.WriteLine($"\nModell: {car.carModel}" +
                                                  $"\tRegistreringsnummer: {car.Regnumber}" +
                                                  $"\n\nRegistrerad datum: {car.Regdate}" +
                                                  $"\tVikt: {car.Carweight}");
                                Console.WriteLine($"\nMiltal: {car.GetCarMiles()}");
                                car.ElectricYesNo();                       
                            }
                           
                        }

                        Console.WriteLine("\nTryck på valfri knapp för att återvända till menyn.");
                        Console.ReadLine();

                        break;

                    case "5":

                        Car.CreateNewCar(CarList);
                        carCount++;
                        break;
                 
                    case "6":
                        Console.Clear();

                        Console.Write("\nMata in vilken bil du vill ändra på: ");
                        int.TryParse(Console.ReadLine(), out int userCarChange);
                        Console.Write("\nMata in det nya miltalet (du kan endast öka): ");
                        float.TryParse(Console.ReadLine(), out float userMilesChange);
                        CarList[userCarChange - 1].SetCarMiles(userMilesChange);

                        break;

                    // Skriver ut alla objekt av klassen Car, som finns sparad i lista.
                    case "7":
                        Console.Clear();

                        for (int i = 0; i < CarList.Count; i++)
                        {
                            Console.WriteLine($"\n-----Registrerad bil nummer: {i + 1}-----");

                            Console.WriteLine($"\nModell: {CarList[i].carModel}" +
                                              $"\tRegistreringsnummer: {CarList[i].Regnumber}" +
                                              $"\n\nRegistrerad datum: {CarList[i].Regdate}" +
                                              $"\tVikt: {CarList[i].Carweight}");
                             Console.WriteLine($"\nMiltal: {CarList[i].GetCarMiles()}");
                             CarList[i].ElectricYesNo();

                            Thread.Sleep(500);                         
                        }

                        Console.WriteLine("\nTryck på valfri knapp för att återvända till menyn.");
                        Console.ReadLine();
                        break;

                    // Rensar listan på registrerade bilar.
                    case "8":

                        CarList.Clear();

                        Console.WriteLine("\nListan med registrerade bilar är nu rensad." +
                                          "\n\nÅtervänder till menyn...");
                        Thread.Sleep(2500);

                        carCount = 0;
                        break;

                    // Avslutar while-loopen och hela programmet.
                    case "9":
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