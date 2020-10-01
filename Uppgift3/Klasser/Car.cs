using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Klasser
{
    public class Car
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
        #region CreateNewCar - Användaren skapar ny bil och lägger till i lista.
        public static void CreateNewCar(List<Car> CarList)
        {
            Console.Clear();
            Car currentCar = new Car();

            Console.Write("\nSkriv in bilens modellnamn: \t");
            var userInputModel = Console.ReadLine();
            currentCar.carModel = userInputModel;

            Console.Write("\nMata in bilens miltal: \t");
            var userInputMiles = int.Parse(Console.ReadLine());
            currentCar.SetCarMiles(userInputMiles).ToString();

            Console.Write("\nMata in bilens registreringsnummer: \t");
            var userInputRegNumber = Console.ReadLine();
            currentCar.Regnumber = userInputRegNumber;

            Console.Write($"\nMata in vikt för bilen med regnummer {currentCar.Regnumber}: \t");
            var userInputWeight = int.Parse(Console.ReadLine());
            currentCar.Carweight = userInputWeight;

            Console.Write($"\nÄr bilen med regnummer {currentCar.Regnumber} en elbil? J/N: \t");
            var userInputElectric = Console.ReadLine().ToUpper();

            if (userInputElectric == "J")
            {
                currentCar.Electric = true;
                currentCar.ElectricYesNo();
            }
            else
            {
                currentCar.Electric = false;
                currentCar.ElectricYesNo();
            }

            DateTime registered = DateTime.Now;
            currentCar.Regdate = registered;
            CarList.Add(currentCar);

            Console.WriteLine("\nDu har registrerat en ny bil. Återvänder till menyn.");
            Thread.Sleep(2500);
        }
        #endregion
        
        public float SetCarMiles(float userInput)
        {
            while (userInput < this.carMiles)
            {
                Console.WriteLine("\nDu kan endast öka miltalet på bilens mätare!");
                Console.Write("\nFörsök mata in ett högre miltal: ");
                userInput = float.Parse(Console.ReadLine());
            }
            this.carMiles = (this.carMiles - this.carMiles) + userInput;
            Console.WriteLine($"\n\tDu har ändrat miltalet på bilens mätare till {userInput}.");
            Thread.Sleep(1000);

            return userInput;

        }

        public string GetCarMiles()
        {
            var carMilesConverted = this.carMiles.ToString();
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
