namespace LetsBowl.BowlingLeague
{
    public interface IBowlerRepository
    {
        public IEnumerable<object>GetAllBowlersWithTeams();
        IEnumerable<Bowler> Bowlers { get; }

        IEnumerable<Team> Teams { get; }
    }
}
