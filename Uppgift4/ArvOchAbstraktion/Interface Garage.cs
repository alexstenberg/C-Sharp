using System;
using System.Collections.Generic;
using System.Text;
using Klasser;

namespace ArvOchAbstraktion
{
    public interface IGarage
    {
         
        void AddVehicleToGarage(ref List<Vehicles> VehicleList);

        void RemoveVehicleFromGarage(ref List<Vehicles> VehicleList);

        void PrintVehiclesInGarage();

    }
}
