using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {

        public static string[] FizzBuzz(long number)
        {
            string[] result = new string[number];
            for (int i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write("'fizzbuzz', ");
                    result[i-1] = "fizzbuzz";
                }
                else if (i % 3 == 0)
                {
                    Console.Write("'fizz', ");
                    result[i-1] = "fizz";
                }
                else if (i % 5 == 0)
                {
                    Console.Write("'buzz', ");
                    result[i-1] = "buzz";
                }
                else
                {
                    Console.Write(i.ToString()+", ");
                    result[i-1] = i.ToString();
                }
            }
            Console.WriteLine();
            return result;
        }

        static long EnterValue()
        {
            Console.WriteLine("Please enter number");

            long number;

            if (!long.TryParse(Console.ReadLine(), out number))
            {
                number = EnterValue();
            }

            return number;
        }


        static void Main(string[] args)
        {
            FizzBuzz(EnterValue());
        }
    }
}
