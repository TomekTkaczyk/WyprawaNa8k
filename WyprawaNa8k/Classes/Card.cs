using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public class Card
    {
        private static int cardNumberSeed = 1234567890;
        private readonly List<Trace> allTraces = new List<Trace>();

        public Card(string owner)
        {
            Owner = owner;
            Number = cardNumberSeed.ToString();
            cardNumberSeed++;
        }

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Distance
        {
            get
            {
                decimal distance = 0;
                foreach (var item in allTraces)
                {
                    distance += item.Kilometers;
                }

                return distance;
            }
        }

        public void RegisterNewTrace(decimal kilometers, string note)
        {
            var trace = new Trace(kilometers, DateTime.Now, note);
            allTraces.Add(trace);
        }

        public string GetAccountHistory()
        {
            var history = new StringBuilder();
            history.AppendFormat("Legitymacja {0} - {1}\n", Number, Owner);
            foreach(Trace item in allTraces)
            {
                history.AppendFormat("Trasa: {0},\t Data: {1},\t Dystans: {2}\n", item.Notes, item.Date.ToShortDateString(), item.Kilometers);
            }
            history.AppendLine();

            return history.ToString();
        }
    }
}
