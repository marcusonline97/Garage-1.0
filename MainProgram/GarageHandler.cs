using Garage_1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.MainProgram
{
    public class GarageHandler
    {
        private Garage _garage = new Garage(15);
        private ConsoleUI consoleUI = new ConsoleUI();

        public void Run ()
        {
            consoleUI.DisplayMenu(_garage);
        }
        public void ParkVehicle(IVehicle vehicle)
        {
            _garage.ParkVehicle(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle) 
        {
            _garage.RemoveVehicle(vehicle);
        }
        public void RemoveVehicle(string registrationID)
        {
            _garage.RemoveVehicle(registrationID);
        }


        public List<IVehicle> GetGarageContents() 
        {
            var contents = new List<IVehicle>();

            return _garage.GetVehicles();
        }
        }
    }
