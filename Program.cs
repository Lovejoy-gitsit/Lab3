using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number = 0;

          

                 //input
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine().ToUpper();
                

            while (true)
            {
                Console.WriteLine(name + ", please enter a number between 1-100: ");
                //number = int.Parse(Console.ReadLine());
                
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                   Console.WriteLine("Invalid");
                   continue;   
                }

                //if integer entered is odd, print the number entered and odd
                if (number % 2 != 0 && number <= 100)
                {
                    Console.WriteLine($"{name}, { number}  is Odd");
                }
                //if the integer entered is even and btwn 2-25 print even and less than 25
                else if (number <= 25)
                {
                    Console.WriteLine($"{name}, {number} is even and less than 25");
                }
                //if the integer is even and btwn 26-60 print even
                else if (number <= 60)
                {
                    Console.WriteLine($"{name}, {number} is Even");
                }

                //if integer is even and greater than 60 print the number entered and even
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"{name}, {number} is Even.");
                }
                else
                {
                    Console.WriteLine("Enter a number between 1-100");
                }
                string input;
                Console.WriteLine($"Do you want to keep guessing, enter y or n ");
                input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
