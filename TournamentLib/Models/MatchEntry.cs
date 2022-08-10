namespace TournamentLib.Models
{
    public class MatchEntry
    {
        public Team TeamCompleting { get; set; }
        public double Score { get; set; }
        public Matchup ParentMatchup { get; set; }
    }
}