using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MySharedLibrary
{
    public class Utilities
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }

        public static bool ValidateEmail(string email)
        {
            // Simplified email validation for demonstration
            return email.Contains("@");
        }
    }
}   



