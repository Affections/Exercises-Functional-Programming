using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToList();
            string command;
            //add 1 to each number
            Func<List<int>, List<int>> add = Add;
            //multiply each number by 2
            Func<List<int>, List<int>> multiply = Multiply;
            //subtract 1 from each number
            Func<List<int>, List<int>> subtract = Subtract;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        add(numbers);
                        break;
                    case "multiply":
                        multiply(numbers);
                        break;
                    case "subtract":
                        subtract(numbers);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    default:
                        break;
                }
            }
        

        }

        private static List<int> Add(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]++;
            }
            return numbers;
        }
        private static List<int> Multiply(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= 2;
            }
            return numbers;
        }
        private static List<int> Subtract(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
            return numbers;
        }
    }
}
