using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .Select(int.Parse);
            
            var number = int.Parse(Console.ReadLine());
            Func<int, bool> filter = n => n % number != 0;

            var leftNumbers = input.Reverse().Where(filter);

            Console.WriteLine(string.Join(" ",  leftNumbers));

        }

  
       
       
    }
}
