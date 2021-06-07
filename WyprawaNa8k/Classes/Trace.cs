using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public class Trace
    {
        public decimal Kilometers { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Trace(decimal kilometers, DateTime date, string note)
        {
            this.Kilometers = kilometers;
            this.Date = date;
            this.Notes = note;
        }
    }
}
