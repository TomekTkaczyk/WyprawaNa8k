using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public abstract class Card
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
        public string Owner { get; }
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

        public void RegisterNewTrace(DateTime date, decimal kilometers, string note)
        {
            allTraces.Add(new Trace(kilometers, date, note));
        }

        public string GetAccountHistory()
        {
            var history = new StringBuilder();
            history.AppendFormat($"Legitymacja {Number} - {Owner}\n");
            foreach (Trace item in allTraces)
            {
                history.Append($"Trasa: {item.Notes},\t Data: {item.Date.ToShortDateString()},\t Dystans: {item.Kilometers}\n");
            }
            history.AppendLine();

            return history.ToString();
        }
    }
}
