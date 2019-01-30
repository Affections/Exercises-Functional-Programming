using System;
using System.Linq;

namespace Problem_12._Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.None).ToArray();
            string command = commands[0];
            string filterType = commands[1];
            int filterParameter = int.Parse(commands[2]);
            var output = numbers;
            while (command != "Forge")
            {
                switch (command)
                {
                    case "Exclude":
                        {
                            switch (filterType)
                            {
                                case "Sum Left":
                                    {
                                        for (int i = 0; i < numbers.Count; i++)
                                        
                                        {
                                            if(i - 1 < 0)
                                            {
                                                if(numbers[i] == filterParameter)
                                                {
                                                    output.Remove(numbers[i]);
                                                }
                                            }
                                            else
                                            {
                                                int previousGemIndex = i - 1;
                                                if ((numbers[i] + numbers[previousGemIndex]) == filterParameter)
                                                {
                                                    output.Remove(numbers[i]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case "Sum Right":
                                    {
                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            if (i + 1 > numbers.Count)
                                            {
                                                if (numbers[i] == filterParameter)
                                                {
                                                    output.Remove(numbers[i]);
                                                }
                                            }
                                            else
                                            {
                                                int nextGemIndex = i + 1;
                                                if ((numbers[i] + numbers[nextGemIndex]) == filterParameter)
                                                {
                                                    output.Remove(numbers[i]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case "Sum Left Right":
                                    {
                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            if (i + 1 > numbers.Count)
                                            {
                                                if (i - 1 < 0)
                                                {
                                                    if (numbers[i] == filterParameter)
                                                    {
                                                        output.Remove(numbers[i]);
                                                    }
                                                }
                                                else
                                                {
                                                    int previousGemIndex = i - 1;
                                                    if ((numbers[i] + numbers[previousGemIndex]) == filterParameter)
                                                    {
                                                        output.Remove(numbers[i]);
                                                    }
                                                }
                                            }
                                            else if (i - 1 < 0)
                                            {
                                                if (i + 1 > numbers.Count)
                                                {
                                                    if (numbers[i] == filterParameter)
                                                    {
                                                        output.Remove(numbers[i]);
                                                    }
                                                }
                                                else
                                                {
                                                    int nextGemIndex = i + 1;
                                                    if ((numbers[i] + numbers[nextGemIndex]) == filterParameter)
                                                    {
                                                        output.Remove(numbers[i]);
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                int nextGemIndex = i + 1;
                                                int previousGemIndex = i-1 ;
                                                if ((numbers[i] + numbers[nextGemIndex] + numbers[previousGemIndex]) == filterParameter)
                                                {
                                                    output.Remove(numbers[i]);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "Reverse":
                        {
                            switch (filterType)
                            {
                                case "Sum Left":
                                    {
                                        foreach (var gem in numbers)
                                        {
                                            if (numbers.IndexOf(gem) - 1 < 0)
                                            {
                                                if (gem == filterParameter)
                                                {
                                                    output.Add(gem);
                                                }
                                            }
                                            else
                                            {
                                                int previousGemIndex = numbers.IndexOf(gem) - 1;
                                                if ((gem + numbers[previousGemIndex]) == filterParameter)
                                                {
                                                    output.Add(gem);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case "Sum Right":
                                    {
                                        foreach (var gem in numbers)
                                        {
                                            if (numbers.IndexOf(gem) + 1 > numbers.Count)
                                            {
                                                if (gem == filterParameter)
                                                {
                                                    output.Add(gem);
                                                }
                                            }
                                            else
                                            {
                                                int nextGemIndex = numbers.IndexOf(gem) + 1;
                                                if ((gem + numbers[nextGemIndex]) == filterParameter)
                                                {
                                                    output.Add(gem);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case "Sum Left Right":
                                    {
                                        foreach (var gem in numbers)
                                        {
                                            if (numbers.IndexOf(gem) + 1 > numbers.Count)
                                            {
                                                if (numbers.IndexOf(gem) - 1 < 0)
                                                {
                                                    if (gem == filterParameter)
                                                    {
                                                        output.Add(gem);
                                                    }
                                                }
                                                else
                                                {
                                                    int previousGemIndex = numbers.IndexOf(gem) - 1;
                                                    if ((gem + numbers[previousGemIndex]) == filterParameter)
                                                    {
                                                        output.Add(gem);
                                                    }
                                                }
                                            }
                                            else if (numbers.IndexOf(gem) - 1 < 0)
                                            {
                                                if (numbers.IndexOf(gem) + 1 > numbers.Count)
                                                {
                                                    if (gem == filterParameter)
                                                    {
                                                        output.Add(gem);
                                                    }
                                                }
                                                else
                                                {
                                                    int nextGemIndex = numbers.IndexOf(gem) + 1;
                                                    if ((gem + numbers[nextGemIndex]) == filterParameter)
                                                    {
                                                        output.Add(gem);
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                int nextGemIndex = numbers.IndexOf(gem) + 1;
                                                int previousGemIndex = numbers.IndexOf(gem) - 1;
                                                if ((gem + numbers[nextGemIndex] + numbers[previousGemIndex]) == filterParameter)
                                                {
                                                    output.Add(gem);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;              
                    default:
                        break;
                }
                commands = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.None).ToArray();
                command = commands[0];
                filterType = commands[1];
                filterParameter = int.Parse(commands[2]);

            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
