using Garage_1._0.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.MainProgram
{
    public class Garage
    {
        private Dictionary<string,IVehicle> _vehicleList;

        public string RegistrationNumber => throw new NotImplementedException();

        public string Color => throw new NotImplementedException();

        public int NumberOfWheels { get; set; }

        public int AmountOfUsedParkingspaces { get => _vehicleList.Count; }
        public int AmountOfAvalivbleParkingspaces { get; private set; } 

        public Garage(int capacity)
        {
            _vehicleList = new Dictionary<string,IVehicle>(capacity);

            AmountOfAvalivbleParkingspaces = capacity;
        }

        public List<IVehicle> GetVehicles()
        {
            return _vehicleList.Values.ToList();
        }
        public bool ParkVehicle(IVehicle vehicle)
        {
            bool canVehiclePark = AmountOfUsedParkingspaces < AmountOfAvalivbleParkingspaces;

            if (!canVehiclePark)
            {
                return false;
            }

            _vehicleList.Add(vehicle.RegistrationNumber, vehicle);
           

            //       Console.WriteLine($"Vehicle parked at slot {i + 1}.");

            return true;
        }
        public bool RemoveVehicle(string registrationID)
        {
            return _vehicleList.Remove(registrationID);
        }

        public bool RemoveVehicle(IVehicle vehicle)
        {
            return RemoveVehicle(vehicle.RegistrationNumber);

            //  Console.WriteLine($"Vehicle removed from slot {i + 1}.");
        }


        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
        // ... other members
    }
}
