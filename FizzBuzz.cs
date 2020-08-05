using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPlay
{
    class FizzBuzz
    {
        public string DoFizzBuzz(int number)
        {
            string str = "";

            if (number % 3 == 0)
                str += "Fizz";


            if (number % 5 == 0)
                str += "Buzz";


            if (str.Length == 0)
            {
                str = number.ToString();
            }

            return str;

        }
    }
}
