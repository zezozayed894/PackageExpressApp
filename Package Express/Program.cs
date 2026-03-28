using System;
// By: Zaid Alzayed

namespace PackageExpressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");

            // Convert the user input from string to a decimal value
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Display error message and end program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            // Prompt the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total dimensions
            decimal dimensionTotal = width + height + length;

            // Check if the package is too big
            if (dimensionTotal > 50)
            {
                // Display error message and end program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculate the shipping quote
            // Formula: (width * height * length * weight) / 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the result formatted as currency with 2 decimal places
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Thank the user
            Console.WriteLine("Thank you!");
            // Keeps the console open so you can see the result
            Console.ReadLine();
        }
    }
}