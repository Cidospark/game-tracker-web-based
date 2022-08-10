using System;
using System.Collections.Generic;

namespace TournamentLib.Models
{
    public class TournamentModel
    {
        public string Tournament { get; set; }
        public decimal EntryFee { get; set; }
        public List<Team> EnteredTeams { get; set; } = new List<Team>();
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        public List<Matchup> Rounds { get; set; } = new List<Matchup>();
    }
}
