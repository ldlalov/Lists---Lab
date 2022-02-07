using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < list1.Count/2; i++)
            {
                sum = list1[i] + list1[list1.Count - 1 - i];
                Console.Write($"{sum} ");
            }
            if (list1.Count % 2 != 0)
            {
                Console.Write($"{list1[list1.Count/2]}");
            }
        }
    }
}
