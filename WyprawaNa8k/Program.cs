using System;
using System.Collections.Generic;
using System.Diagnostics;
using WyprawaNa8k.Classes;

namespace WyprawaNa8k
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie07();
        }

        private static void Zadanie07()
        {
            var member01 = new MemberCard("Tomek", "Organization01");
            var member02 = new MemberCard("Adam", "Organization02");
            var sherpa01 = new SherpaCard("Kim", "Sherpa1");
            var Guide = new GuideCard("Leon", "Przewodnik01");

            var startDay = DateTime.Now;
            var endDay = startDay.AddDays(1);

            TripWithGroup trip01 = new TripWithGroup(startDay, endDay, 1000, "Trace01");
            trip01.AddMemberToTrip(member01);
            trip01.AddMemberToTrip(sherpa01);
            Guide.RegisterNewTrip(trip01);
            Guide.AddMemberToTrip(trip01, member02);
            Console.WriteLine(Guide.SayVictory());

            TripWithGroup trip02 = new TripWithGroup(startDay, endDay, 20, "Trace02");
            trip02.AddMemberToTrip(member01);
            trip02.AddMemberToTrip(sherpa01);
            Guide.RegisterNewTrip(trip02);
            Guide.AddMemberToTrip(trip02, member02);
            Console.WriteLine(Guide.SayVictory());

            TripWithGroup trip03 = new TripWithGroup(startDay, endDay, 60, "Trace02");
            trip03.AddMemberToTrip(member01);
            trip03.AddMemberToTrip(sherpa01);
            Guide.RegisterNewTrip(trip03);
            Guide.AddMemberToTrip(trip03, member02);
            Console.WriteLine(Guide.SayVictory());
        }

        private static void Zadanie06()
        {
            //var card1 = new MemberCard("Tomek", "Organizacja1");
            //card1.RegisterNewTrace(10, "trasa 1");
            //card1.RegisterNewTrace(5, "trasa 2");
            //card1.RegisterNewTrace(24, "trasa 3");
            //card1.RegisterNewTrace(18, "trasa 4");

            //var card2 = new MemberCard("Adam", "Organizacja2");
            //card2.RegisterNewTrace(2, "trasa 5");
            //card2.RegisterNewTrace(10, "trasa 1");
            //card2.RegisterNewTrace(13, "trasa 6");
            //card2.RegisterNewTrace(24, "trasa 3");

            //Console.WriteLine(card1.GetAccountHistory());
            //Console.WriteLine(card2.GetAccountHistory());
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
