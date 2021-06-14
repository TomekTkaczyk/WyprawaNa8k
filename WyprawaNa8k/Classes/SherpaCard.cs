using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public class SherpaCard : Card
    {
        private List<TripWithGroup> trips = new List<TripWithGroup>();

        public SherpaCard(string owner, string sherpaId) : base(owner) 
        {
            SherpaId = sherpaId;
        }

        public string SherpaId { get; }

        public void RegisterNewTripWithGroup(DateTime startTime, DateTime endTime, int kilometers, string note)
        {
            trips.Add(new TripWithGroup(startTime, endTime, kilometers, note));
        }

        public override string SayVictory()
        {
            return "It was very hard";
        }
    }
}
