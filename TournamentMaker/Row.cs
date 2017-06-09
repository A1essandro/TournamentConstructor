namespace TournamentMaker
{
    class Row
    {

        private IGameUnit _gameUnit;
        private int _scores;

        public Row(IGameUnit gameUnit, int scores = 0)
        {
            _gameUnit = gameUnit;
            _scores = scores;
        }

    }
}
