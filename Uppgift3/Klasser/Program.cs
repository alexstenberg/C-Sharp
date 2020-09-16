using System;
using System.Collections.Generic;
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
            bool showMenu = true;
            List<string> allCars = new List<string>();



            while (showMenu)
            {
                showMenu = MainMenu();
            }
            
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("[1] Registrera ny bil");
            Console.WriteLine("[2] Visa alla registrerade bilar");
            Console.WriteLine("[3] ");
            Console.WriteLine("[4] ");
            Console.WriteLine("[5] Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }

        }
    }

    public class Car
    {
        public int Carweight { get; set; }
        private DateTime Regdate { get; set; }
        public bool Electric { get; set; }

        public string carModel;
        private int carMiles;

        public Car(string carModel, int carMiles)
        {
            this.carModel = carModel;
            this.carMiles = carMiles;
        }

        public int GetCarMiles()

        public void ElectricYesNo()
        {
            if (Electric == true)
            {
                Console.WriteLine("\n\tDetta är en elbil.");
            }
            else
            {
                Console.WriteLine("\n\tDetta är inte en elbil.");
            }
        }


    }
}