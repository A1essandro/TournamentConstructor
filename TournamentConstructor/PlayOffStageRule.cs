using System;

namespace TournamentConstructor
{
    public class PlayOffStageRule : IStageRule
    {

        private int _pairs;
        private int _gamesPerPair;

        public PlayOffStageRule(int pairs, int gamesPerPair = 1)
        {
            _pairs = pairs;
            _gamesPerPair = gamesPerPair;
        }

        public Tuple<int, int>[][] GetSchedule()
        {
            var result = new Tuple<int, int>[_gamesPerPair][];
            for(int tourIndex = 0; tourIndex < _gamesPerPair; tourIndex++)
            {
                result[tourIndex] = new Tuple<int, int>[_pairs];
                for (int gameIndex = 0; gameIndex < _pairs; gameIndex++)
                {
                    result[tourIndex][gameIndex] = new Tuple<int, int>(gameIndex * 2, gameIndex * 2 + 1);
                }
            }
            return result;
        }
    }
}
