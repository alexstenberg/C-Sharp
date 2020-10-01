using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasser
{

    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }

        public List<Car> OwnedCars { get; set; }


        public Person(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
        }

        public static void CreateNewPerson(List<Person> PersonList)
        {
            Console.Clear();

            Console.Write("\nSkriv in namnet på personen: ");
            var userInputName = Console.ReadLine();
            Console.Write("\nSkriv in personens ålder: ");
            int.TryParse(Console.ReadLine(), out int userInputAge);

            PersonList.Add(new Person(userInputName, userInputAge));
        }

        public static void AddCarToPerson(List<Person> PersonList, List<Car> CarList)
        {
            Console.Clear();

            Console.Write("\nVilken person vill du registrera bil på? \n\nAnge siffran personen är registrerad som: ");
            int.TryParse(Console.ReadLine(), out int userInputWhatPerson);
            Person whatPerson = PersonList[userInputWhatPerson - 1];

            Console.Write("\n\nVilken bil vill du registrera på personen? \n\nAnge siffran den är registrerad som: ");
            int.TryParse(Console.ReadLine(), out int userInputWhatCar);
            Car whatCar = CarList[userInputWhatCar - 1];

            PersonList[userInputWhatPerson - 1].OwnedCars = new List<Car>();
            whatPerson.OwnedCars.Add(whatCar);
            CarList.RemoveAt(userInputWhatCar - 1);

            Console.WriteLine($"\n\nBil med regnummber: {whatCar.Regnumber} är nu registrerad på: {whatPerson.FirstName}.");

            Console.WriteLine("\nTryck på valfri knapp för att återvända till menyn.");
            Console.ReadLine();
        }


    }
    
}

