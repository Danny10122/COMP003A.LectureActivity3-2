/*
 * Author: Daniel Juarez    
 * Course: COMP003-A
 * Faculty: Jonathan Cruz
 * Purpose: Demostrate iterative statements in C#
 */
namespace COMP003A.LectureActivity3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iterative Statements Demo!\n");

            // Prompt for a positive integer
            int num;
            Console.Write("Enter a positive integer to generate its multiplication table: ");
            num = int.Parse(Console.ReadLine());

            // Generate multiplication table using a for loop 
            Console.WriteLine($"Muliplication Table for {num}:");
            // loop to generate the multiplication table 
            // the first statement initializes the loop veriable i to 1
            // the second statement specifies the condition for the loop to continue 
            // the third statement increments the loop variable i by 1
            for (int i = 1; i <= 10; i++)
            {
                // display the multiplication table 
                Console.WriteLine($"{i} x {num} = {i * num}");
            }

            // Display table in reverse using a while loop
            Console.WriteLine("\nReversed Muliplication Table:");
            int reverse = 10; // start at 10 
            // loop to generate the multiplication table in reverse
            while (reverse > 0)
            {
                // display the multiplication yable in reverse 
                Console.WriteLine($"{reverse} x {num} = {reverse * num}");
                // decrement reverse
                reverse--;
            }
        }
    }
}
