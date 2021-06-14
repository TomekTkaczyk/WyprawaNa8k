using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public class TripWithGroup
    {
        public TripWithGroup(DateTime startTime, DateTime endTime, decimal kilometers, string note)
        {
            try
            {
                Note = note;
                if (kilometers <= 0 || kilometers > 200)
                {
                    throw new ArgumentOutOfRangeException(nameof(kilometers), "Wrong kilometers.");
                }
                if (startTime > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(startTime), "Wrong start date.");
                }
                if (startTime > endTime)
                {
                    throw new ArgumentOutOfRangeException(nameof(endTime), "Wrong end date.");
                }
                StartTime = startTime;
                EndTime = endTime;
                Kilometers = kilometers;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public decimal Kilometers { get; }
        public string Note { get; }

        public List<Card> Members = new List<Card>();

        public void AddMemberToTrip(Card member)
        {
            if(Kilometers != 0)
            {
                member.RegisterNewTrace(StartTime, Kilometers, Note);
                Members.Add(member);
            }
            else
            {
                Console.WriteLine($"The tour {Note} cannot be held.");
            }
        }
    }
}
