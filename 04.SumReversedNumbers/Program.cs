using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int sum = ReverseDIgitsAndSum(numbers);

            Console.WriteLine(sum);
        }

        static int ReverseDIgitsAndSum(List<int> numbers)
        {
            int sum = 0;
            for (int index = 0; index < numbers.Count; index++)
            {
                int currentNumber = numbers[index];
                string reversedNumber = "";

                while (currentNumber > 0)
                {
                    if (currentNumber % 10 != 0) reversedNumber += (currentNumber % 10).ToString();
                    currentNumber /= 10;
                }

                sum += int.Parse(reversedNumber);
            }

            return sum;
        } 
    }
}
