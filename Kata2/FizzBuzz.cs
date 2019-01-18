using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2
{
    public class FizzBuzz
    {
        public string fb(int num)
        {
            string w = "";
            int count = 0;
            for (int i=num; i >= 1; i--)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count == 2 && (num % 5 == 0))
            {
                w = "BuzzWhiz";
            }
            else if (count == 2 && (num % 3 == 0))
            {
                w = "FizzWhiz";
            }
            else if (count == 2)
            {
                w = "Whiz";
            }
            else if ((num % 3 == 0) && (num % 5 == 0))
            {
                w = "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                w = "Fizz";
            }
            else if(num % 5 == 0)
            {
                w = "Buzz";
            }
            else
            {
                w = num.ToString();
            }
            return w;
        }
    }
}
