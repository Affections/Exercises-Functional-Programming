using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Find_Evens_or_Odds
{
    class Program
    {
        static string command;
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            var range = new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                range.Add(i);
            }
            command = Console.ReadLine();
            Func<List<int>, List<int>> numbers = FilterNumbers;
            var output = numbers(range);
            Console.WriteLine(string.Join(" ",output));

        }

        private static List<int> FilterNumbers(List<int> range)
        {
            var filteredNumbers = new List<int>();
                         
            switch (command)
            {
                case "odd":
                    foreach (var number in range)
                    {
                        if(number % 2 != 0)
                        {
                            filteredNumbers.Add(number);
                        }
                    }
                    break;
                case "even":
                    foreach (var number in range)
                    {
                        if (number % 2 == 0)
                        {
                            filteredNumbers.Add(number);
                        }
                    }
                    break;
            }
            return filteredNumbers;

        }
    }
}
