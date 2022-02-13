using System;

namespace SumSImpleNumber
{
    public class Program
    {
        static int SearchSimple(int[] Arr)
        {
            int emptyValues = 0;
            bool marker;
            for (int i = 0; i < Arr.Length; i++)
            {
                marker = true;
                for (int j = 2; j < Arr[i]; j++)

                    if (Arr[i] % j == 0) marker = false;

                if (marker) emptyValues += Arr[i];
            }
            return emptyValues;
        }
        static int SumSilpleNumber(int max)
        {
            int[] Arr = new int[max];
            for (int i = 1; i < Arr.Length; i++)
            {
                Arr[i] = i + 1;
            }
            return SearchSimple(Arr);
        }
        static void Main(string[] args)
        {
            var max = 10;
            var simpleSum = SumSilpleNumber(max);
            Console.WriteLine(simpleSum);
        }
    }
}
