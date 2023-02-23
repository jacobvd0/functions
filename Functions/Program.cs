using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Functions // Note: actual namespace depends on the project name.
{
    internal class Functions
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square function: {SquareOfNumbers(2, 1)}");

            Console.WriteLine($"Reverse of Test: {ReverseString("Test")}");

            Console.WriteLine($"6 divisible by 3: {DivisibleBy3(6)}");

            AskForName();





            // Adds 2 numbers together then returns the square root of them
            double SquareOfNumbers(int num1, int num2)
            {
                return Math.Sqrt(num1 + num2);
            }

            // Takes a string then reverses it
            string ReverseString(string input)
            {
                string result = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    result = result + input[i];
                    
                }
                return result;
            }

            // Checks if a number is divisible by 3
            bool DivisibleBy3(int num)
            {
                if (num % 3 == 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }

            // Asks for first name and gives error if theres a space
            void AskForName()
            {
                // Asks for name
                Console.WriteLine("Please enter your first name:");
                string name = Console.ReadLine();

                // Loops through every character in the name and checks if there is a space
                for (int i = 0; i <= name.Length - 1; i++)
                {
                    if (char.ToString(name[i]) == " ")
                    {
                        Console.WriteLine("Error: Name contains a space");
                        return;
                    }
                }
                Console.WriteLine($"Hi {name}!");
            }
        }
    }
}