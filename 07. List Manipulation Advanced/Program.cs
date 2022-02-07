using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            bool listChanged = false;
            while ((input = Console.ReadLine()) != "end")
            {
                listChanged = false;
                string[] split = input.Split();
                switch (split[0])
                {
                    case "Add":
                        list1.Add(int.Parse(split[1]));
                        listChanged = true;
                        break;
                    case "Remove":
                        list1.Remove(int.Parse(split[1]));
                        listChanged = true;
                        break;
                    case "RemoveAt":
                        list1.RemoveAt(int.Parse(split[1]));
                        listChanged = true;
                        break;
                    case "Insert":
                        list1.Insert(int.Parse(split[2]), int.Parse(split[1]));
                        listChanged = true;
                        break;

                    case "Contains":
                        if(list1.Contains(int.Parse(split[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (int num in list1)
                        {
                            if (num % 2 == 0)
                            {
                                Console.Write($"{num} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (int num in list1)
                        {
                            if (num % 2 != 0)
                            {
                                Console.Write($"{num} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (int num in list1)
                        {
                            sum += num;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = split[1];
                        int number = int.Parse(split[2]);
                        switch (condition)
                        {
                            case "<":
                                for (int i = 0; i < list1.Count; i++)
                                {
                                    if (list1[i] < number)
                                    {
                                        Console.Write($"{list1[i]} "); ;
                                    }    
                                }
                                break;
                            case ">":
                                for (int i = 0; i < list1.Count; i++)
                                {
                                    if (list1[i] > number)
                                    {
                                        Console.Write($"{list1[i]} "); ;
                                    }
                                }
                                break;
                            case ">=":
                                for (int i = 0; i < list1.Count; i++)
                                {
                                    if (list1[i] >= number)
                                    {
                                        Console.Write($"{list1[i]} "); ;
                                    }
                                }
                                break;
                            case "<=":
                                for (int i = 0; i < list1.Count; i++)
                                {
                                    if (list1[i] <= number)
                                    {
                                        Console.Write($"{list1[i]} "); ;
                                    }
                                }
                                break;
                        }
                                Console.WriteLine();
                       break;
                }

            }
            if (listChanged)
            {
                Console.WriteLine(String.Join(' ', list1));
            }
        }
    }
}
