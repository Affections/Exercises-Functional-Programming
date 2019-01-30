using System;
using System.Linq;

namespace Problem_7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int allowedLength = int.Parse(Console.ReadLine());
            Func<string, bool> filter = s => s.Length <= allowedLength;
            Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.None)
               .Where(filter)
               .ToList()
               .ForEach(s => Console.WriteLine(s));
        }
    }
}
