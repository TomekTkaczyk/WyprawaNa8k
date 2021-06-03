using System;
using System.Collections.Generic;

namespace WyprawaNa8k
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie02();
            Zadanie03();
            Zadanie04();
            Zadanie05();
        }

        private static void Zadanie05()
        {
            const int countNumbers = 20;
            List<int> fibonacciNumbers = new List<int> { 1, 1 };
            for(int i = 2; i < countNumbers; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1]);
            }
            Console.WriteLine(@"{0} liczba ciągu Fibonacciego to {1}", countNumbers, fibonacciNumbers[countNumbers-1]);
        }

        private static void Zadanie04()
        {
            int sum = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(@"Suma liczb podzielnych przez 7 wynosi {0}", sum);
        }

        private static void Zadanie03()
        {
            double radius = 2.5;

            Console.WriteLine(@"Pole powierzchni koła o promieniu {0} wynosi {1}", radius, Math.PI * radius * radius);
        }

        private static void Zadanie02()
        {
            Console.WriteLine("Hej Ekipa z kursu 8k!");
        }
    }
}
