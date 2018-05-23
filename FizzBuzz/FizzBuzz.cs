using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Print(int i)
        {
            /* Before refactoring.
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (i % 3 == 0)
            {
                return "Fizz";
            }

            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return i.ToString(); */

            // After refactoring.
            string word = null;

            if (i % 3 == 0)
            {
                word = "Fizz";
            }

            if (i % 5 == 0)
            {
                word += "Buzz";
            }

            return word ?? i.ToString();
        }
    }
}
