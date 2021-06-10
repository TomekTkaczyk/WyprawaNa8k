using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public class GuideCard : Card
    {
        public GuideCard(string owner, string GuideId) : base(owner)
        {
            this.GuideId = GuideId;
        }

        public string GuideId { get; }
        public List<TripWithGroup> Trips = new List<TripWithGroup>();

        public void RegisterNewTrip(TripWithGroup trip)
        {
            Trips.Add(trip);
        }

        public void AddMemberToTrip(TripWithGroup trip, Card member)
        {
            if (Trips.Contains(trip))
            {
                trip.AddMemberToTrip(member);
            }
        }
    }
}                             
