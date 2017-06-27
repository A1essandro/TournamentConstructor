using System;
using TournamentConstructor.Game;

namespace TournamentConstructor.GameUnit.Position
{
    public class Position<TMeetFact> : IComparable<Position<TMeetFact>>
        where TMeetFact : IMeetFact
    {

        public Position(IGameUnit gameUnit)
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

        public int CompareTo(Position<TMeetFact> other)
        {
            var winsCompare = Wins.CompareTo(other.Wins);
            if (winsCompare == 0)
            {
                return -Drafts.CompareTo(other.Drafts);
            }

            return -winsCompare;
        }

        public ushort Wins { get; private set; }

        public ushort Loses { get; private set; }

        public ushort Drafts { get; private set; }

    }
}
