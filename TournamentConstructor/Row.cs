namespace TournamentConstructor
{
    class Row
    {

        public IGameUnit GameUnit { get; protected set; }
        public int Scores { get; protected set; }

        public Row(IGameUnit gameUnit, int scores = 0)
        {
            GameUnit = gameUnit;
            Scores = scores;
        }

    }
}
