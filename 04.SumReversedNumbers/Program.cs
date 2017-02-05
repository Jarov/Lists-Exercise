using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<BigInteger> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToList();

            BigInteger sum = ReverseDIgitsAndSum(numbers);

            Console.WriteLine(sum);
        }

        static BigInteger ReverseDIgitsAndSum(List<BigInteger> numbers)
        {
            BigInteger sum = 0;
            for (int index = 0; index < numbers.Count; index++)
            {
                BigInteger currentNumber = numbers[index];
                string reversed = "";

                if (currentNumber == 0)
                {
                    reversed = "0";
                }

                while (currentNumber > 0)
                {
                    reversed += (currentNumber % 10).ToString();
                    currentNumber /= 10;
                }
                sum += BigInteger.Parse(reversed);
            }

            return sum;
        } 
    }
}
