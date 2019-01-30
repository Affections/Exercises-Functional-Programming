using System;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> output = s => Console.WriteLine(s);
            Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .ToList()
                .ForEach(output);
                
        }
    }
}
