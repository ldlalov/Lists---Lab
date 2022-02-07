using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] < 0)
                {
                    list1.Remove(list1[i]);
                    i--;
                }
            }
            if (list1.Count>0)
            {
                list1.Reverse();
            Console.WriteLine(String.Join(' ',list1));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
