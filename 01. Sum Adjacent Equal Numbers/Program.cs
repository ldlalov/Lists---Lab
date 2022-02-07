using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < list1.Count-1; i++)
            {
                if (list1[i]==list1[i+1])
                {
                    list1[i] *= 2;
                    list1.RemoveAt(i+1);
                    i=-1;
                }

            }
            Console.WriteLine(String.Join(' ', list1));
        }
    }
}
