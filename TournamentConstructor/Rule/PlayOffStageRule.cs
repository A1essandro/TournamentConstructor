using System;
using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.GameUnit.Status;

namespace TournamentConstructor.Rule
{
    public class PlayOffStageRule<TMeetType> : IStageRule<TMeetType>
        where TMeetType : IMeetFact
    {
        private readonly uint _pairs;

        public PlayOffStageRule(uint pairs)
        {
            _pairs = pairs;
        }

        public uint PassCount => _pairs;

        public IEnumerable<IGameUnit> GetPassing(IStage<TMeetType> stage)
        {
            return stage.GameUnits.Where(p => p.Status.Any(s => s.Key == stage)).ToList();
        }

        public virtual Tuple<int, int>[][] GetSchedule()
        {
            var result = new Tuple<int, int>[1][];
            result[0] = new Tuple<int, int>[_pairs];
            for (var gameIndex = 0; gameIndex < _pairs; gameIndex++)
            {
                result[0][gameIndex] = new Tuple<int, int>(gameIndex * 2, gameIndex * 2 + 1);
            }
            return result;
        }

        public virtual void SetStatuses(IStage<TMeetType> stage)
        {
            foreach (var game in stage.Tours.SelectMany(tour => tour.Games))
            {
                game.Result.Winner.AddStatus(stage, new PairWinner());
            }
        }

    }
}