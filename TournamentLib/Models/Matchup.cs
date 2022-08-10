using System.Collections.Generic;

namespace TournamentLib.Models
{
    public class Matchup
    {
        public List<MatchEntry> Entries { get; set; } = new List<MatchEntry>();
        public Team Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}