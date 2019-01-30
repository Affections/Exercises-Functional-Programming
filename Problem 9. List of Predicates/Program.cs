using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToList();
            var output = new List<int>();
            bool isDevideable = true;
            for (int i = 1; i <= endOfRange; i++)
            {
                for (int c = 0; c < dividers.Count; c++)
                {
                    if(i%dividers[c] != 0)
                    {
                        isDevideable = false;
                    }
                }
                if(isDevideable == true)
                {
                    output.Add(i);
                }
                else
                {
                    isDevideable = true;
                }                  
            }
            Console.WriteLine(string.Join(" ",output));


        }
    }
}
