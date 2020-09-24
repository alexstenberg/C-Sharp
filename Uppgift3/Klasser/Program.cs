using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
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
            int carCount = 0;
            bool showMenu = true;
            List<Car> CarList = new List<Car>();

            while (showMenu)
            {
                /// Skriv ut alternativ i meny.
                Console.Clear();
                Console.WriteLine("\n[1] Registrera ny bil.");
                Console.WriteLine("\n[2] Ändra miltal på bil.");
                Console.WriteLine("\n[3] Skriv ut alla registrerade bilar.");
                Console.WriteLine("\n[4] Ta bort alla bilar ur register.");
                Console.WriteLine("\n[5] Avsluta\n");
                
                // Switch för menyalternativ, tar emot en sträng.
                switch (Console.ReadLine())
                {

                    case "1":
                        Console.Clear();

                        Console.Write("\nSkriv in bilens modellnamn: \t");
                        var userInputModel = Console.ReadLine();
                        CarList.Add(new Car());
                        CarList[carCount].carModel = userInputModel;

                        Console.Write("\nMata in bilens miltal: \t");
                        var userInputMiles = int.Parse(Console.ReadLine());
                        CarList[carCount].SetCarMiles(userInputMiles).ToString();

                        Console.Write("\nMata in bilens registreringsnummer: \t");
                        var userInputRegNumber = Console.ReadLine();
                        CarList[carCount].Regnumber = userInputRegNumber;

                        Console.Write($"\nMata in vikt för bilen med regnummer {CarList[0].Regnumber}: \t");
                        var userInputWeight = int.Parse(Console.ReadLine());
                        CarList[carCount].Carweight = userInputWeight;

                        Console.Write($"\nÄr bilen med regnummer {CarList[carCount].Regnumber} en elbil? J/N: \t");
                        var userInputElectric = Console.ReadLine().ToUpper();

                        if (userInputElectric == "J")
                        {
                            CarList[carCount].Electric = true;
                            CarList[carCount].ElectricYesNo();
                        }
                        else
                        {
                            CarList[carCount].Electric = false;
                            CarList[carCount].ElectricYesNo();
                        }

                        DateTime registered = DateTime.Now;
                        CarList[carCount].Regdate = registered;

                        Console.WriteLine("\nDu har registrerat en ny bil. Återvänder till menyn.");
                        Thread.Sleep(2500);

                        carCount++;
                        showMenu = true;
                        break;

                    // Ändrar miltal på ett objekt av klassen Car, som finns sparad i lista.
                    case "2":
                        Console.Clear();

                        Console.Write("\nMata in vilken bil du vill ändra på: ");
                        int userCarChange = int.Parse(Console.ReadLine());
                        Console.Write("\nMata in det nya miltalet (du kan endast öka): ");
                        float userMilesChange = float.Parse(Console.ReadLine());
                        CarList[userCarChange - 1].SetCarMiles(userMilesChange);

                        showMenu = true;
                        break;

                    // Skriver ut alla objekt av klassen Car, som finns sparad i lista.
                    case "3":
                        Console.Clear();

                        for (int i = 0; i < CarList.Count; i++)
                        {
                            Console.WriteLine($"\n-----Registrerad bil nummer: {i + 1}-----");

                            Console.WriteLine($"\nModell: {CarList[i].carModel}" +
                                              $"\tRegistreringsnummer: {CarList[i].Regnumber}" +
                                              $"\nRegistrerad datum: {CarList[i].Regdate}" +
                                              $"\tVikt: {CarList[i].Carweight}");
                             Console.WriteLine($"\nMiltal: {CarList[i].GetCarMiles()}");
                             CarList[i].ElectricYesNo();

                            Thread.Sleep(500);                         
                        }

                        Console.WriteLine("\nTryck på valfri knapp för att återvända till menyn.");
                        Console.ReadLine();
                        showMenu = true;
                        break;

                    // Rensar listan på registrerade bilar.
                    case "4":
                        Console.Clear();
                        CarList.Clear();

                        Console.WriteLine("\nListan med registrerade bilar är nu rensad." +
                                          "\n\nÅtervänder till menyn...");
                        Thread.Sleep(2500);

                        carCount = 0;
                        showMenu = true;
                        break;

                    // Avslutar while-loopen och hela programmet.
                    case "5":
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