// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Arrays_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Asks the user to enter a whole number for the array size
            Console.WriteLine("User, please enter a whole number to be your array size.");
            // Gives user input and converts it to an integer under arraySize
            int arraySize = Convert.ToInt32(Console.ReadLine());
            // Initiallizes an integer array to the size the user inputted
            int[] numbers = new int[arraySize];
            // Sets the integer sum to 0
            int sum = 0;

            // Creates a for statement in which the integer i is 0 and if i is less than numbers.Length then add more i
            for(int i = 0; i < numbers.Length; i++)
            {
                // Asks the user to enter another whole number to add to the array
                Console.WriteLine("User, please enter another whole number to add to your array.");
                // Gives user input and converts it to an integer under numbers[i]
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                // States numbers[i] will be added to equal the sum
                sum += numbers[i];
            }
            // Tells the user the sum of the array
            Console.WriteLine($"The sum of the array is {sum}, user.");

            // Sorts the array numbers in ascending order
            Array.Sort(numbers);

            // Tells user Array:
            Console.WriteLine("Array:");
            // Creates a foreach statement to find the integer number in numbers
            foreach(int number in numbers)
            {
                //States the numbers the user inputted in ascending order
                Console.WriteLine(number);
            }
        }
    }
}
