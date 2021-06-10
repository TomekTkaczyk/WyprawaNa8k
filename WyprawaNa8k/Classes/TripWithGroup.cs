using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public class TripWithGroup
    {
        public TripWithGroup(DateTime startTime, DateTime endTime, decimal kilometers, string note)
        {
            StartTime = startTime;
            EndTime = endTime;
            Kilometers = kilometers;
            Note = note;

        }

        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public decimal Kilometers { get; }
        public string Note { get; }

        public List<Card> Members = new List<Card>();

        public void AddMemberToTrip(Card member)
        {
            member.RegisterNewTrace(StartTime, Kilometers, Note);
            Members.Add(member);
        }
    }
}
