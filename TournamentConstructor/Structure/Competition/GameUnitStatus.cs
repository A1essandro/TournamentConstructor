using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure.Competition
{
    public abstract class GameUnitStatus<TMeetFact>
    {

        protected GameUnitStatus(IGameUnit gameUnit)
        {
            GameUnit = gameUnit;
        }

        public readonly IGameUnit GameUnit;

        public abstract void Calculate(TMeetFact meetResult);

        public uint Wins { get; private set; }

        protected void AddWin()
        {
            Wins++;
        }

        public uint Loses { get; private set; }

        protected void AddLose()
        {
            Loses++;
        }

        public uint Drafts { get; private set; }

        protected void AddDraft()
        {
            Drafts++;
        }

    }
}
