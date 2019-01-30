using System;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> getMin = GetMin;
            int minNumber = GetMin(numbers);
            Console.WriteLine(minNumber);
            
                
        }

        private static int GetMin(int[] numbers)
        {
            int min = int.MaxValue;
            foreach (var number in numbers )
            {
                if(number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
