using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(new string[] { " " }, StringSplitOptions.None)
                 .Select(int.Parse);
            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }
            evenNumbers.Sort();
            oddNumbers.Sort();

            Console.Write(string.Join(" ", evenNumbers));
            Console.Write(" ");
            Console.Write(string.Join(" ", oddNumbers));
        }
    }
}
