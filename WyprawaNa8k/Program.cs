using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WyprawaNa8k
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Timing oparty na Stopwatch[ms]");
            TimeCounter2();

            Console.WriteLine();
            Console.WriteLine("Timing oparty na DateTime[tics]");
            TimeCounter1();

            Console.ReadKey();

        }

        private static void TimeCounter1()
        {
            DateTime start;
            DateTime stop;

            start = DateTime.Now;
            Zadanie05();
            stop = DateTime.Now;
            Console.WriteLine(@"Czas wykonania w pętli [tics]: {0}", (stop - start).Ticks);

            start = DateTime.Now;
            Zadanie05a();
            stop = DateTime.Now;
            Console.WriteLine(@"Czas wykonania w rekurencji [tics]: {0}", (stop - start).Ticks);

            start = DateTime.Now;
            Zadanie05();
            stop = DateTime.Now;
            Console.WriteLine(@"Czas wykonania w pętli [tics]: {0}", (stop - start).Ticks);

            start = DateTime.Now;
            Zadanie05a();
            stop = DateTime.Now;
            Console.WriteLine(@"Czas wykonania w rekurencji [tics]: {0}", (stop - start).Ticks);

            start = DateTime.Now;
            Zadanie05();
            stop = DateTime.Now;
            Console.WriteLine(@"Czas wykonania w pętli [tics]: {0}", (stop - start).Ticks);

            start = DateTime.Now;
            Zadanie05a();
            stop = DateTime.Now;
            Console.WriteLine(@"Czas wykonania w rekurencji [tics]: {0}", (stop - start).Ticks);
        }

        private static void TimeCounter2()
        {
            Stopwatch watch;

            watch = Stopwatch.StartNew();
            Zadanie05();
            watch.Stop();
            Console.WriteLine(@"Czas wykonania w pętli [ms]: {0}", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            Zadanie05a();
            watch.Stop();
            Console.WriteLine(@"Czas wykonania w rekurencji [ms]: {0}", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            Zadanie05();
            watch.Stop();
            Console.WriteLine(@"Czas wykonania w pętli [ms]: {0}", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            Zadanie05a();
            watch.Stop();
            Console.WriteLine(@"Czas wykonania w rekurencji [ms]: {0}", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            Zadanie05();
            watch.Stop();
            Console.WriteLine(@"Czas wykonania w pętli [ms]: {0}", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            Zadanie05a();
            watch.Stop();
            Console.WriteLine(@"Czas wykonania w rekurencji [ms]: {0}", watch.ElapsedMilliseconds);

        }


        private static void Zadanie05a()
        {
            const int countNumbers = 10000;
            Console.WriteLine(@"{0} liczba ciągu Fibonacciego to {1}", countNumbers, Fibonacci(countNumbers)[countNumbers-1]);
        }

        private static IList<ulong> Fibonacci(int count)
        {
            if (count > 2)
            {
                var fi = Fibonacci(count - 1);
                fi.Add(fi[count - 2] + fi[count - 3]);
                return fi;
            }
            else
            {
                return new List<ulong> { 1, 1 };
            }
        }

        private static void Zadanie05()
        {
            const int countNumbers = 20000;
            List<ulong> fibonacciNumbers = new List<ulong> { 1, 1 };
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
