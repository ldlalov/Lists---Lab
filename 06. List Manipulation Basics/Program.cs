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
            while ((input = Console.ReadLine()) != "end")
            {
                string [] split = input.Split();
                switch (split[0])
                {
                    case "Add":
                        list1.Add(int.Parse(split[1]));
                        break;
                    case "Remove":
                        list1.Remove(int.Parse(split[1]));
                        break;
                    case "RemoveAt":
                        list1.RemoveAt(int.Parse(split[1]));
                        break;
                    case "Insert":
                        list1.Insert(int.Parse(split[2]), int.Parse(split[1]));
                        break;
                }
            }
            Console.WriteLine(String.Join(' ', list1));
        }
    }
}
