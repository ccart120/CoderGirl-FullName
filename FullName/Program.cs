using System;

namespace FullName
{
    public static class Program
    {


        public static void Main()



        {
            string fName = "";
            string lName = "";
            
            // TODO: Ask the user for their first name and then their last name.
            Console.WriteLine("Enter your first name: ");
            fName = (Console.ReadLine());
            Console.WriteLine("Enter your last name: ");
            lName = (Console.ReadLine());
            
            // TODO: Call a method called FullName that returns their full name.
            string wholeName = FullName(fName, lName);
            
            // TODO: Output their full name.
            
            Console.ReadLine();
            Console.WriteLine(wholeName);
        }
        
        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.

        public static string FullName(string fName , string lName)
        {
            return (fName + " " + lName);

        }
        
    }
        
}
