using System;
using System.Collections.Generic;
using System.Linq;

namespace Мending_machine
{
    class Program
    {
        static List<double> Aoo(ref double change, double cash, List<double> list)
        {
            if (change - cash >= 0)
            {
                list.Add(cash);
                change -= cash;
                Aoo(ref change, cash, list);
                return list;
            }
            Console.Write($"{list[0]} руб: {list.Count()}шт.,");
            return list;
        }
        static void Foo(double price, double money)
        {
            double change = money - price;
            double[] Cash = { 5000, 2000, 1000, 500, 200, 100, 50, 10, 5, 2, 1 };
            var listCash = new List<double>();
            for (int i = 0; i < Cash.Length; i++)
            {
                if (change >= Cash[i])
                {
                    listCash = Aoo(ref change, Cash[i], listCash);

                }
                listCash.Clear();
            }
        }
        static void Main(string[] args)
        {
            var price = 21;
            var money = 50;
            Foo(price, money);
        }
    }
}

