using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Team_Repo
{
    public enum IdentifyMember 
    {
        TeamMember = 1,
        IdNumber = 2,
        pluralSight = 3,
    }
    // pogo //
    public class DevTeam
    {
        public string TeamMember { get; set; }
        public int IdNumber { get; set; }
        public IdentifyMember MemberIdentifier { get; set; }
        public bool PluralSight { get; set; }

        public DevTeam () { }
        public DevTeam(string teamMember, int idNumber, bool pluralSight)
        {
            TeamMember = teamMember;
            IdNumber = idNumber;
            PluralSight = pluralSight;
        }

    }
}
