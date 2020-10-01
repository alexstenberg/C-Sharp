using System;
using System.Collections.Generic;
using System.Text;
using Klasser;

namespace ArvOchAbstraktion
{

    interface IGarage
    {

        void AddVehicleToGarage(List<Vehicle> whatVehicle);

        void RemoveVehicleFromGarage(string removeItem);

    }
    public class Garage : IGarage
    {

        public void AddVehicleToGarage(List<Vehicle> whatVehicle)
        {
            Console.Write("\nVilket fordon vill du lägga till i garaget?: ");
            //VehiclesInGarage.Add(whatVehicle);
        }

        public void RemoveVehicleFromGarage(string removeItem)
        {
            Console.Write("\nVilket fordon vill du ta bort från garaget?: ");
        }

        public List<Garage> VehiclesInGarage { get; set; }
    }

    //public class Garage2 : IGarage
    //{
    //    public void AddVehicleToGarage()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void RemoveVehicleFromGarage()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
