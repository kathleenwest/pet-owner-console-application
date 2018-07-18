using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampApplication
{
    // LampMain: This class is the entry and main control
    // for the Lamp Application. It creates the lamp object
    // and starts the application features. 
    class LampMain
    {
        // This is the main entry point of the Lamp application that
        // creates the lamp object and triggers the feature actions
        static void Main(string[] args)
        {
            //Arrange the Console Window
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Lamp Application";

            // Create a lamp object
            Lamp myLamp = new Lamp();

            //Start the Lamp program
            myLamp.Start();

            // Wait for the User Input
            Console.ReadLine();
        }
    }
}
