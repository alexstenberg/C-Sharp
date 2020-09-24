using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Klasser
{
    class Car
    {
        public int Carweight { get; set; }
        public string Regnumber { get; set; }
        public DateTime Regdate { get; set; }
        public bool Electric { get; set; }

        public string carModel;
        private float carMiles;

        public Car()
        { }

        public Car(string carModel, int carMiles)
        {
            this.carModel = carModel;
            this.carMiles = carMiles;
        }

        public float SetCarMiles(float userInput)
        {
            while (userInput < this.carMiles)
            {
                Console.WriteLine("\nDu kan endast öka miltalet på bilens mätare!");
                Console.Write("\nFörsök mata in ett högre miltal: ");
                userInput = float.Parse(Console.ReadLine());
            }
            this.carMiles = (this.carMiles - this.carMiles) + userInput;
            Console.WriteLine($"\n\tDu har ändrat miltalet på bilens mätare till {userInput}");
            Thread.Sleep(2000);

            return userInput;

        }

        public string GetCarMiles()
        {
            string carMilesConverted = this.carMiles.ToString();
            return carMilesConverted;
        }

        public void ElectricYesNo()
        {
            if (Electric == true)
            {
                Console.WriteLine("\nDetta är en elbil.\n");
            }
            else
            {
                Console.WriteLine("\nDetta är inte en elbil.\n");
            }
        }
    }
}
