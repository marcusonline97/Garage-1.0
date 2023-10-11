using Garage_1._0.MainProgram;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Interfaces
{
    public class ConsoleUI
    {
        public void DisplayMenu(Garage garage)
        {
            while (true)
            {
                Console.WriteLine("1. Park a vehicle");
                Console.WriteLine("2. Remove a vehicle");
                Console.WriteLine("3. Display garage contents");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine()!;
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        IVehicle vehicle = UserCreateVehicle();

                        if (vehicle == null) // Creation went wrong, handle
                        {
                            Console.WriteLine($"An Error Occured, You may have applied a none supported vehicle, please try again");
                        }
                        else
                        {
                            // Creation worked

                            bool carAdded = garage.ParkVehicle(vehicle);
                            if (carAdded)
                            {
                                Console.WriteLine($"parking spot for {vehicle} has been Added");
                            }
                            else
                            {
                                Console.WriteLine($"An error occured, please try again");
                            }
                        }

                        break;
                    case "2":
                        string registrationID = UserFetchRegistrationID();
                        bool carGone = garage.RemoveVehicle(registrationID);
                        if (carGone)
                        {
                            Console.WriteLine($"parking spot for {registrationID} has been cleared");
                        }
                        else
                        {
                            Console.WriteLine($"An error occured, please try again");
                        }
                        break;
                    case "3":
                        DisplayGarageContents(garage.GetVehicles());
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


        private IVehicle UserCreateVehicle() //The function within the UI that handles the creation of logic for the user
        {
            Console.WriteLine("Enter the type of vehicle (Car, Motorcycle, Airplane, etc.): ");
            string vehicleType = Console.ReadLine()!;

            Console.WriteLine("Enter the registration number: ");
            string registrationNumber = Console.ReadLine()!;

            Console.WriteLine("Enter the color of the vehicle: ");
            string color = Console.ReadLine()!;

            IVehicle vehicle = CreateVehicle(vehicleType, registrationNumber, color);

            return vehicle;
        }

        private string UserFetchRegistrationID()
        {
            Console.WriteLine("Enter the registration number of the vehicle to remove: "); // Output
            string registrationNumber = Console.ReadLine()!; // Input

            return registrationNumber;

            //IVehicle vehicleToRemove = registrationNumber;
            
            // garageHandler.RemoveVehicle(vehicleToRemove); // Logic
          //  Console.WriteLine("Vehicle removed successfully!"); // Output
        }

        private void DisplayGarageContents(List<IVehicle> vehicles)
        {
            Console.WriteLine("Garage contents: \n");
            foreach (IVehicle vehicle in vehicles) // For every vehicle, store them in vehicles
            {
                Console.WriteLine($"{vehicle.Color} {vehicle.GetType().Name} ({vehicle.RegistrationNumber})");
            }
        }
   
        private IVehicle CreateVehicle(string vehicleType, string registrationNumber, string color)
        {
            string vehicleTypeLow = vehicleType.ToLower().Trim();

            switch (vehicleTypeLow)
            {
                case "car":
                    return new Car (registrationNumber ,color, 4 );
                case "motorcycle":
                    return new Motorcycle (registrationNumber, color, 2 );
                case "airplane":
                    return new Airplane (registrationNumber, color, 0);
                case "bus":
                    return new Bus (registrationNumber, color, 6);
                case "boat":
                    return new Boat(registrationNumber, color, 0);
                
                // Add cases for other vehicle types as needed
                default:
                    return null!;
            }
        }
    }


}
