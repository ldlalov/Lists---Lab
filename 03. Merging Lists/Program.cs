using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list3 = new List<int>();
            if (list1.Count>=list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    list3.Add(list1[i]);
                    list3.Add(list2[i]);
                }
                for (int i = list2.Count; i < list1.Count; i++)
                {
                    list3.Add(list1[i]);
                }
                Console.WriteLine(String.Join(' ', list3));
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    list3.Add(list1[i]);
                    list3.Add(list2[i]);
                }
                for (int i = list1.Count; i < list2.Count; i++)
                {
                    list3.Add(list2[i]);
                }
                Console.WriteLine(String.Join(' ', list3));
            }
        }
    }
}
