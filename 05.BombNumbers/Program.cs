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
            List<int> numbersToRemove = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int index = 0; index < numbersToRemove.Count; index++)
            {
                numbers.RemoveAll(x => x == numbersToRemove[index]);
            }

            int sum = 0;

            for (int index = 0; index < numbers.Count; index++)
            {
                sum += numbers[index];
            }

            Console.WriteLine(sum);
        }
    }
}
