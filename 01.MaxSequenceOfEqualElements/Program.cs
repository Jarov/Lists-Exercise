using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int index = 0;
            int maxIndex = 0;
            int count = 1;
            int maxCount = 1;

            while (index < numbers.Count - 1)
            {
                if (numbers[index] == numbers[index + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxIndex = index;
                }

                index++;
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{numbers[maxIndex]} ");
            }
        }
    }
}
