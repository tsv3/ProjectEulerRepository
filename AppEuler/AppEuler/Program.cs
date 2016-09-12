using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEuler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Int64 answer = 0;

            Console.Write("Task1: Find the sum of all the multiples of multiplesNumber1 or multiplesNumber2 below belowNumber.\n");
            answer = SumMultiplesBelow(3, 5, 1000); 
            if (answer > 0)
                Console.Write("Found the sum is {0}\n", answer);

            Console.Write("Task2: Find the sum of the even-valued terms in the Fibonacci sequence whose values do not exceed limit\n");
            answer = EvenFibonacciNumbers(4000000);
            if (answer > 0)
                Console.Write("Found the sum is {0} \n", answer);

            Console.Write("Task3: Find the smallest positive number that is evenly divisible by all of the numbers from number1 to number2.\n");
            answer = SmallestMultiple(1, 20);
            if (answer > 0)
                Console.Write("Smallest positive number is {0}\n", answer);

            Console.ReadKey();


        }

        /// <summary>
        /// Find the sum of all the multiples of multiplesNumber1 or multiplesNumber2 below belowNumber.
        /// </summary>
        /// <param name="multiplesNumber1">multiple of number 1</param>
        /// <param name="multiplesNumber2">multiple of number 2</param>
        /// <param name="belowNumber">Natural number, below which is found the sum of all the multiples.</param>
        public static int SumMultiplesBelow(int multiplesNumber1, int multiplesNumber2, int belowNumber)
        {
            int sum = 0;

            if (multiplesNumber1 > 0 && multiplesNumber2 > 0 && multiplesNumber1 <= multiplesNumber2)
            {
                for (int i = 1; i < belowNumber; i++)
                {
                    if (i % multiplesNumber1 == 0 || i % multiplesNumber2 == 0)
                    {
                        sum = sum + i;

                    }

                }


            }
            else
            {
                Console.Write("You entered incorrect data\n");

            }

            return sum;


        }

        /// <summary>
        /// Find the sum of the even-valued terms in the Fibonacci sequence whose values do not exceed limit
        /// </summary>
        /// <param name="limit">Value that  do not exceed Fibonacci sequence</param>
        public static Int64 EvenFibonacciNumbers(Int64 limit)
        {
            Int64 x = 1, y = 2, sum;
            Int64 evensum = 2;

            if (limit > 1)
            {
                while ((x + y) < limit)
                {
                    sum = x + y;
                    x = y;
                    y = sum;
                    if (sum % 2 == 0)
                        evensum += sum;
                }




            }
            else
            {
                evensum = 0;
                Console.Write("You entered incorrect data\n");

            }

            return evensum;

        }


        /// <summary>
        /// Find the smallest positive number that is evenly divisible by all of the numbers from number1 to number2.
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        public static int SmallestMultiple(int number1, int number2)
        {
            int i = number2;

            if (number1 > 0 && number2 > 0 && number1 <= number2)
            {
                bool flag = false;

                while (true)
                {
                    for (int j = number1; j <= number2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }

                    }

                    if (flag)
                    {
                        break;
                    }

                    i++;

                }




            }
            else
            {
                i = 0;
                Console.Write("You entered incorrect data\n");


            }

            return i;

        }

    }
}
