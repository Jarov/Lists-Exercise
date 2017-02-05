using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); 
            List<int> bombard = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (numbers.Contains(bombard[0]))
            {
                int bombardedNumberCount = 1;

                int index = numbers.FindIndex(x => x == bombard[0]);

                while (bombardedNumberCount <= bombard[1] && bombardedNumberCount <= index)
                {
                    numbers.RemoveAt(index - bombardedNumberCount);
                    bombardedNumberCount++;
                }

                bombardedNumberCount = bombard[1];

                index = numbers.FindIndex(x => x == bombard[0]);

                if (bombardedNumberCount > numbers.Count - 1 - index)
                    bombardedNumberCount = numbers.Count - 1 - index;

                while (bombardedNumberCount > 0)
                {
                    numbers.RemoveAt(index + bombardedNumberCount);
                    bombardedNumberCount--;
                }

                numbers.RemoveAt(index);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
