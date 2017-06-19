using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure
{
    public class Row
    {
        public Row(IGameUnit gameUnit, int scores = 0)
        {
            GameUnit = gameUnit;
            Scores = scores;
        }

        public IGameUnit GameUnit { get; protected set; }
        public int Scores { get; protected set; }
    }
}