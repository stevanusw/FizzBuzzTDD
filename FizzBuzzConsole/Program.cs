using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            for (var i = 1; i<=100; i++)
            {
                Console.WriteLine($"{i} is {fizzBuzz.Print(i)}.");
            }

            Console.Read();
        }
    }
}
