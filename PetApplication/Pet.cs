using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApplication
{
    // Pet: This class is the main object for the Pet Application
    // that will store the instance fields or attributes for the Pet
    // as well as provide features or available actions for the pet
    // object
    class Pet
    {
        private string name; // name of the pet
        private int age; // age as an integer
        private bool isFemale; // true if female, false if otherwise

        // This is the main entry point feature action method
        // that triggers all the objects options
        public void Start()
        {
            Console.WriteLine(); // blank line
            Console.WriteLine(" Greetings from a Pet object!");
            Console.WriteLine(); // blank line

            ReadAndSavePetData();
            DisplayPetInfo();
        }

        // Method to Read User Input and Same Pet Information
        public void ReadAndSavePetData()
        {
            // Ask user for the name of the pet
            ReadName();

            // Ask the user for the pet age
            ReadAge();

            // Ask user if pet is female or male
            ReadGender();
  
        }

        // This method Reads and Saves a Pet Name
        public void ReadName()
        {
            Console.Write("What is the name of your pet?: ");
            name = Console.ReadLine();
        }

        // This method Reads and Saves a Pet's Age
        public void ReadAge()
        {
            Console.Write("What is the age of " + name + "?: ");
            string textValue = Console.ReadLine();
            age = int.Parse(textValue); // convert the string to a number
        }

        //This method Reads and Saves a Pet's Gender
        public void ReadGender()
        {
            Console.Write("Is your pet a female (y/n)? ");
            char response = char.Parse(Console.ReadLine());
            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;
        }

        // Method to Display Pet Information on Console
        public void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            string textOut = "Name: " + name + " Age: " + age;
            Console.WriteLine(textOut);
            if (isFemale)
                Console.WriteLine(name + " is a good girl!");
            else
                Console.WriteLine(name + " is a good boy!");        
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
