using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .ToList();
            string[] commands = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None);
       
          
            while (commands[0] != "Party!")
            {
                switch (commands[0])
                {
                    case "Double":
                        {
                            switch (commands[1])
                            {
                                case "StartsWith":
                                {
                                        for (int i = 0; i < people.Count; i++)
                                        {
                                            if (people[i].StartsWith(commands[2]))
                                            {
                                                people.Add(people[i]);
                                            }
                                        }
                                    }
                                    break;
                                case "EndsWith":
                                    {
                                        for (int i = 0; i < people.Count; i++)
                                        {
                                            if (people[i].EndsWith(commands[2]))
                                            {
                                                people.Add(people[i]);
                                            }
                                        }
                                    }
                                    break;
                                case "Length":
                                    {
                                        int count = people.Count;
                                        for (int i = 0; i < count; i++)
                                        {
                                            if(people[i].Length == int.Parse(commands[2]))
                                            {
                                                people.Insert(0,people[i]);
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "Remove":
                        {
                            switch (commands[1])
                            {
                                case "StartsWith":
                                    {
                                        for (int i = 0; i < people.Count; i++)
                                        {
                                            if (people[i].StartsWith(commands[2]))
                                            {
                                                people.Remove(people[i]);
                                            }
                                        }
                                    }
                                    break;
                                case "EndsWith":
                                    {
                                        for (int i = 0; i < people.Count; i++)
                                        {
                                            if (people[i].EndsWith(commands[2]))
                                            {
                                                people.Remove(people[i]);
                                            }
                                        }
                                    }
                                    break;
                                case "Length":
                                    {
                                        int count = people.Count;
                                        for (int i = 0; i < count; i++)
                                        {
                                            if (people[i].Length == int.Parse(commands[2]))
                                            {
                                                people.Remove(people[i]);
                                                break;
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
                commands = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.None); 
            }
            if(people.Count > 0)
            {
              
                Console.Write(string.Join(", ",people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
