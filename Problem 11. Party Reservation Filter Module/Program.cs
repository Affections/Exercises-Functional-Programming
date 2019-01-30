using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11._Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var invititations = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .ToList();
            var invitedPeople = new List<string>();
            int count = 0;
           
            string[] command = Console.ReadLine()
                .Split(new string[] { ";" }, StringSplitOptions.None).ToArray();
            while (command[0] != "Print")
            {
                switch (command[0])
                {
                    case "Add filter":
                        {
                            switch(command[1])
                            {
                                case "Starts with":
                                    count = invititations.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if(invititations[i].StartsWith(command[2]))
                                        {
                                            invitedPeople.Add(invititations[i]);
                                            invititations.Remove(invititations[i]);
                                            count = invititations.Count;
                                           
                                        }
                                    }
                                    break;
                                case "Ends with":
                                    count = invititations.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (invititations[i].EndsWith(command[2]))
                                        {
                                            invitedPeople.Add(invititations[i]);
                                            invititations.Remove(invititations[i]);
                                            count = invititations.Count;
                                          
                                        }
                                    }
                                    break;
                                case "Length":
                                    count = invititations.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (invititations[i].Length == int.Parse(command[2]))
                                        {
                                            invitedPeople.Add(invititations[i]);
                                            invititations.Remove(invititations[i]);
                                            count = invititations.Count;
                                           
                                        }
                                    }
                                    break;

                                case "Contains":
                                    count = invititations.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (invititations[i] == command[2])
                                        {
                                            invitedPeople.Add(invititations[i]);
                                            invititations.Remove(invititations[i]);
                                            count = invititations.Count;
                                           
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    break;
                    case "Remove filter":
                        {
                            switch (command[1])
                            {
                                case "Starts with":
                                    count = invitedPeople.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (invitedPeople[i].StartsWith(command[2]))
                                        {
                                            invititations.Insert(0,invitedPeople[i]);
                                            invitedPeople.Remove(invitedPeople[i]);
                                            count = invitedPeople.Count;
                                           
                                        }
                                    }
                                    break;
                                case "Ends with":
                                    count = invitedPeople.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (invitedPeople[i].EndsWith(command[2]))
                                        {
                                            invititations.Insert(0, invitedPeople[i]);
                                            invitedPeople.Remove(invitedPeople[i]);
                                            count = invitedPeople.Count;

                                        }
                                    
                                    }
                                    break;
                                case "Length":
                                    count = invitedPeople.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (invitedPeople[i].Length == int.Parse(command[2]))
                                        {
                                            invititations.Insert(0, invitedPeople[i]);
                                            invitedPeople.Remove(invitedPeople[i]);
                                            count = invitedPeople.Count;
                                           

                                        }
                                    }
                                    break;

                                case "Contains":
                                    count = invitedPeople.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        if (invitedPeople[i] == command[2])
                                        {
                                            invititations.Insert(0,invitedPeople[i]);
                                            invitedPeople.Remove(invitedPeople[i]);
                                            count = invitedPeople.Count;
                                           

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
                command = Console.ReadLine()
                .Split(new string[] { ";" }, StringSplitOptions.None)
                .ToArray();
            }

            Console.WriteLine(string.Join(" ",invititations));
        }
    }
}
