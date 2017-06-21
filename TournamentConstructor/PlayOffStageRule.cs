using System;
using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.GameUnit.Status;

namespace TournamentConstructor
{
    public struct PlayOffStageRule : IStageRule
    {
        private readonly int _pairs;
        private readonly int _gamesPerPair;

        public PlayOffStageRule(int pairs, int gamesPerPair = 1)
        {
            _pairs = pairs;
            _gamesPerPair = gamesPerPair;
        }

        public Tuple<int, int>[][] GetSchedule()
        {
            var result = new Tuple<int, int>[_gamesPerPair][];
            for (var tourIndex = 0; tourIndex < _gamesPerPair; tourIndex++)
            {
                result[tourIndex] = new Tuple<int, int>[_pairs];
                for (var gameIndex = 0; gameIndex < _pairs; gameIndex++)
                {
                    if (tourIndex%2 == 0)
                    {
                        result[tourIndex][gameIndex] = new Tuple<int, int>(gameIndex*2, gameIndex*2 + 1);
                    }
                    else
                    {
                        result[tourIndex][gameIndex] = new Tuple<int, int>(gameIndex*2 + 1, gameIndex*2);
                    }
                }
            }
            return result;
        }

        public void SetStatuses<TMeetType>(IStage<TMeetType> stage)
        {
            foreach (var game in stage.Tours.SelectMany(tour => tour.Games))
            {
                UnitPairWithResults.GetPair(game.Players.Item1, game.Players.Item2)
                    .SetResult(game.Result as Match); //TODO: need to review
            }

            foreach (var winner in UnitPairWithResults.Pairs.Select(pair => pair.GetWinnerThenLoser().Item1))
            {
                winner.AddStatus(stage, new PairWinner());
            }
        }

        private class UnitPairWithResults
        {
            private KeyValuePair<IGameUnit, double> _team1;
            private KeyValuePair<IGameUnit, double> _team2;

            private UnitPairWithResults(IGameUnit team1, IGameUnit team2)
            {
                _team1 = new KeyValuePair<IGameUnit, double>(team1, 0);
                _team2 = new KeyValuePair<IGameUnit, double>(team2, 0);
            }

            public static IList<UnitPairWithResults> Pairs { get; } = new List<UnitPairWithResults>();

            public static UnitPairWithResults GetPair(IGameUnit team1, IGameUnit team2)
            {
                var result = Pairs.SingleOrDefault(x => (x._team1.Key == team1 && x._team2.Key == team2)
                                                        || (x._team1.Key == team2 && x._team1.Key == team2));

                if (result != null) return result;

                result = new UnitPairWithResults(team1, team2);
                Pairs.Add(result);
                return result;
            }

            public void SetResult(Match result)
            {
                var homeScores = result.Score.Item1.Value;
                var awayScores = result.Score.Item2.Value + 0.00001*result.Score.Item2.Value;
                if (result.Score.Item1.Key == _team1.Key)
                {
                    _team1 = new KeyValuePair<IGameUnit, double>(_team1.Key, _team1.Value + homeScores);
                    _team2 = new KeyValuePair<IGameUnit, double>(_team2.Key, _team2.Value + awayScores);
                }
                else
                {
                    _team1 = new KeyValuePair<IGameUnit, double>(_team1.Key, _team1.Value + awayScores);
                    _team2 = new KeyValuePair<IGameUnit, double>(_team2.Key, _team2.Value + homeScores);
                }
            }

            public Tuple<IGameUnit, IGameUnit> GetWinnerThenLoser()
            {
                var winner = _team1.Value > _team2.Value ? _team1.Key : _team2.Key;
                var loser = _team1.Key == winner ? _team2.Key : _team1.Key;
                return new Tuple<IGameUnit, IGameUnit>(winner, loser);
            }
        }
    }
}