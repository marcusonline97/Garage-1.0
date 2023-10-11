using Garage_1._0.Interfaces;
using Garage_1._0.MainProgram;
using System.Collections.Generic;

namespace Garage_1._0
{
    public class Program
    {
       private static GarageHandler _handler = new GarageHandler();
        static void Main()
        { 
            while (true)
            {
               _handler.Run();
            }


        }
    }
}