using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string action = "";

            while (action != "print")
            {
                string[] inPut = Console.ReadLine().Split(' ');
                action = inPut[0];

                int position = 0;
                if (inPut.Length > 1)
                    position = int.Parse(inPut[1]);

                switch (action)
                {
                    case "add":
                        int value = int.Parse(inPut[2]);
                        Add(numbers, position, value);
                        break;
                    case "addMany":
                        List<int> values = new List<int>();
                        for (int index = 2; index < inPut.Length; index++)
                        {
                            values.Add(int.Parse(inPut[index]));
                        }
                        AddMany(numbers, position, values);
                        break;
                    case "contains":
                        Console.WriteLine(Contains(numbers, position));
                        break;
                    case "remove":
                        Remove(numbers, position);
                        break;
                    case "shift":
                        ShiftLeft(numbers, position);
                        break;
                    case "sumPairs":
                        SumPairs(numbers);
                        break;
                    case "print":
                        Print(numbers);
                        break;
                }
            }
        }

        static void Add(List<int> numbers, int position, int value)
        {
            numbers.Insert(position, value);
        }

        static void AddMany(List<int> numbers, int position, List<int> values)
        {
            numbers.InsertRange(position, values);
        }

        static int Contains(List<int> numbers, int number)
        {
            for (int index = 0; index < numbers.Count; index++)
            {
                if (number == numbers[index])
                {
                    return index;
                }
            }

            return -1;
        }

        static void Remove(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        static void ShiftLeft(List<int> numbers, int rotations)
        {
            for (int rotate = 0; rotate < rotations; rotate++)
            {
                int firstNumber = numbers.First();
                for (int index = 0; index < numbers.Count - 1; index++)
                {
                    numbers[index] = numbers[index + 1];
                }
                numbers[numbers.Count - 1] = firstNumber;
            }
        }

        static void SumPairs(List<int> numbers)
        {
            for (int index = 0; index < numbers.Count - 1; index++)
            {
                numbers[index] += numbers[index + 1];
                numbers.RemoveAt(index + 1);
            }
        }

        static void Print(List<int> numbers)
        {
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
