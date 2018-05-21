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
           

                 //input
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine().ToUpper();
                OE.GetNumber(name);
            while (OE.PlayAgain())
            {
                OE.GetNumber(name);
            }
        }
    }
}
