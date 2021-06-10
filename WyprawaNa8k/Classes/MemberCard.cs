using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k.Classes
{
    public class MemberCard : Card
    {
        public MemberCard(string owner, string organization) : base(owner)
        {
            Organization = organization;
        }

        public string Organization { get; }
    }
}
