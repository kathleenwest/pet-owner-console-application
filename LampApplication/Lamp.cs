using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampApplication
{
    // Lamp: This class is the main object for the Lamp Application
    // that will store the instance fields or attributes for the lamp
    // as well as provide features or available actions for the lamp
    // object
    class Lamp
    {
        private string location;    //location of the lamp in my house
        private bool isOn;          // state of the lamp 
        private bool isSmart;       // true if connected to a smart home system

        // This is the main entry point feature action method
        // that triggers all the objects options
        public void Start()
        {
            // Configure the lamp settings
            Configure();

            // Display the Lamp State
            DisplayState();
        }

        // This method configures the instance fields 
        public void Configure()
        {
            // Set Location
            Console.Write("Which room in the house is this lamp located? :");
            location = Console.ReadLine();

            // Set Smart Home System
            Console.Write("Is this part of a smart home management system (y/n)? :");
            char response = char.Parse(Console.ReadLine());
            if ((response == 'y') || (response == 'Y'))
                isSmart = true;
            else
                isSmart = false;

            // Set Lamp State
            Console.Write("Would you like to turn on this lamp (y/n)? :");
            response = char.Parse(Console.ReadLine());
            if ((response == 'y') || (response == 'Y'))
                TurnOn();
            else
                TurnOff();

        }

        // Method to Turn on Lamp
        public void TurnOn()
        {
            isOn = true;
        }

        // Method to Turn off the lamp
        public void TurnOff()
        {
            isOn = false;
        }

        // This method will print out the lamp object
        // status of instance fields to the console
        public void DisplayState()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Lamp Location: " + location);
            if (isSmart)
                Console.WriteLine("This lamp is a smart lamp device");
            else
                Console.WriteLine("Manual switching on/off is required");
            if (isOn)
                Console.WriteLine("Status: Turned On");
            else
                Console.WriteLine("Status: Turned Off");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

    }
}
