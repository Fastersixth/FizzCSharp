using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter a number to calculate fizzbuz, or q to exit.");
                string input = Console.ReadLine();
                if (input.ToLower().Equals("q"))
                    return;
                string result = CalculateFizzBuzz(int.Parse(input));
                Console.WriteLine(result);
            }
        }


        /**
        * Should return Fizz if number is dividable by 3
        * Should return Buzz if number is dividable by 5
        * Should return FizzBuzz if number is dividable by 3 and 5
        * @param input
        **/
        public static string CalculateFizzBuzz(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            if (input % 5 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            return "";
        }
    }
}