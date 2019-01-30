using System;
using System.Linq;

namespace Problem_2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> output = s => Console.WriteLine($"Sir {s}");
            Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .ToList()
                .ForEach(output);

        }
    }
}
