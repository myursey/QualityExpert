using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { -1,1,2,-3,3 };
            Console.WriteLine(GetPairsCount(arr));
        }

        private static int GetPairsCount(int[] arr)
        {
            var counter = 0;

            var list = arr.ToList();
            list.Sort();

            while (list.Count > 1)
            {
                var a = list.First();
                list.Remove(a);
                var b = list.First();

                if (a == b
                    || a + 1 == b
                    || a + 2 == b
                    || a - 1 == b
                    || a - 2 == b)
                {
                    list.Remove(b);
                }

                ++counter;
            }

            if (list.Count == 1)
            {
                ++counter;
            }

            return counter;
        }
    }
}