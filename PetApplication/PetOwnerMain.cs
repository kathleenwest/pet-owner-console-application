using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApplication
{
    // PetOwnerMain: This class is the entry and main control
    // for the Pet Owner Application. It creates the pet object
    // and starts the application features. 
    class PetOwnerMain
    {
        // This is the main entry point for the Pet application
        // and triggers the creation of an object and the method call
        static void Main(string[] args)
        {
            //Arrange the Console Window
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Pet Owner";
            
            
            // Declare and instantiate a pet object
            Pet myPet = new Pet();

            // Run the Start method in the Pet object
            myPet.Start();

            // Print out Exit Message to User
            Console.WriteLine("Press Enter to Exit");

            // Wait for the User Input
            Console.ReadLine();
        }
    }
}
