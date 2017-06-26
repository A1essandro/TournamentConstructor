using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure.Competition
{
    public class GameUnitStatus<TMeetFact> where TMeetFact : IMeetFact
    {

        protected GameUnitStatus(IGameUnit gameUnit)
        {
            GameUnit = gameUnit;
        }

        public readonly IGameUnit GameUnit;

        public virtual void Calculate(TMeetFact meetResult)
        {
            if (meetResult.IsDraft)
            {
                Drafts++;
            }
            else if (meetResult.Winner == GameUnit)
            {
                Wins++;
            }
            else
            {
                Loses++;
            }
        }

        public uint Wins { get; private set; }

        public uint Loses { get; private set; }

        public uint Drafts { get; private set; }

    }
}
