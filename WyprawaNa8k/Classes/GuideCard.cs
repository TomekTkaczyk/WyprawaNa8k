using System;
using System.Collections.Generic;
using System.Linq;
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
            if(trip.Kilometers != 0)
            {
                Trips.Add(trip);
            }
        }

        public void AddMemberToTrip(TripWithGroup trip, Card member)
        {
            if (Trips.Contains(trip))
            {
                trip.AddMemberToTrip(member);
            }
            else
            {
                Console.WriteLine($"The tour {trip.Note} cannot be held.");
            }
        }

        public override string SayVictory()
        {
            var result = new StringBuilder();
            result.Append($"I'am finish {Trips.Count} trip(s) with total {Trips.Select(x => x.Kilometers).Sum()} kilometers.");

            return result.ToString();

        }
    }
}                             
