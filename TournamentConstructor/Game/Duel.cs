using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public class Duel : IMeetFact
    {
        public Duel(IGameUnit winner, IGameUnit loser)
        {
            Winner = winner;
            Loser = loser;
        }


        public Duel(IMeet<Duel> meet, IGameUnit winner)
        {
            if (meet.Players.Item1 == winner)
            {
                Winner = meet.Players.Item1;
                Loser = meet.Players.Item2;
            }
            else
            {
                Winner = meet.Players.Item2;
                Loser = meet.Players.Item1;
            }
        }

        public bool IsDraft => false;
        public IGameUnit Winner { get; }
        public IGameUnit Loser { get; }
    }
}