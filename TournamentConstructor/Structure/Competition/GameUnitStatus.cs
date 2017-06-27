using System;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure.Competition
{
    public class GameUnitStatus<TMeetFact> : IComparable<GameUnitStatus<TMeetFact>>
        where TMeetFact : IMeetFact
    {

        public GameUnitStatus(IGameUnit gameUnit)
        {
            GameUnit = gameUnit;
        }

        public readonly IGameUnit GameUnit;

        public virtual void AddResult(TMeetFact meetResult)
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

        public int CompareTo(GameUnitStatus<TMeetFact> other)
        {
            var winsCompare = Wins.CompareTo(other.Wins);
            if (winsCompare == 0)
            {
                return Drafts.CompareTo(other.Drafts);
            }

            return winsCompare;
        }

        public ushort Wins { get; private set; }

        public ushort Loses { get; private set; }

        public ushort Drafts { get; private set; }

    }
}
