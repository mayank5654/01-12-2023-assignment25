using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Demonstrate using the shared library in MainApp

                // Log a message
                MySharedLibrary.Utilities.LogMessage("Application started.");

                // Validate an email
                string email = "user@example.com";
                bool isValidEmail = MySharedLibrary.Utilities.ValidateEmail(email);

                Console.WriteLine($"Is {email} a valid email? {isValidEmail}");

                // Additional modules can be added to demonstrate more functionalities
            
        }
    }

}