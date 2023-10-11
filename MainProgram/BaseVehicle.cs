using Garage_1._0.Interfaces;
using Garage_1._0.MainProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.MainProgram
{
    public abstract class BaseVehicle : IVehicle
    {
        public string RegistrationNumber { get; set; } //Used for registration (Needs to be unique)
        public string Color { get; set; } //Can be any color that the user inserts
        public int NumberOfWheels { get; set; }

        public int Capacity { get; set; }

        public override string ToString()
        {
            return "[" + this.GetType().Name + "] (" + RegistrationNumber + ") " + Color;
        }
        public virtual void Start()
        {
            Console.WriteLine("Vehicle Started");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
    }
}
public class GroundVehicle : BaseVehicle //Inherited Vehicle specified in Ground based Vehicles
{
}

public class WaterBasedVehicle : BaseVehicle
{
}

public class AirBourneVehicles : BaseVehicle
{
}
public class Airplane : AirBourneVehicles
{
    public Airplane(string registrationNumber, string color, int numberOfWheels)
    {
        RegistrationNumber = registrationNumber;
        Color = color;
        NumberOfWheels = numberOfWheels;
    }
}

public class Motorcycle : GroundVehicle
{
    public Motorcycle(string registrationNumber, string color, int numberOfWheels)
    {
        RegistrationNumber = registrationNumber;
        Color = color;
        NumberOfWheels = numberOfWheels;
    }
    //Implement MotorCycle Logic
}

public class Car : GroundVehicle
{
    //Implement Car Logic
    public Car(string registrationNumber, string color, int numberOfWheels)
    {
        RegistrationNumber = registrationNumber;
        Color = color;
        NumberOfWheels = numberOfWheels;
    }

    public int Horsepower { get; set; }
}

public class Bus : GroundVehicle
{
    public Bus(string registrationNumber, string color, int numberOfWheels = 6)
    {
        RegistrationNumber = registrationNumber;
        Color = color;
        NumberOfWheels = numberOfWheels;
    }
    //Implement Bus Logic
}

public class Boat : WaterBasedVehicle
{
    public Boat(string registrationNumber, string color, int numberOfWheels = 0)
    {
        RegistrationNumber = registrationNumber;
            Color = color;
        NumberOfWheels = numberOfWheels;
    }
}
