using System;
using System.Collections.Generic;

namespace TournamentLib.Models
{
    public class Team
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }
    }
}
