using System;
using System.Collections.Generic;

namespace TournamentConstructor.Structure.Competition.Scheduler
{
    public class SwissScheduler : IScheduler
    {

        public ushort ToursCount { get; private set; }

        private ushort _players;

        public SwissScheduler(ushort players, ushort tours)
        {
            ToursCount = tours;
            _players = players;
        } 

        public IEnumerable<IEnumerable<Tuple<int, int>>> GetTours()
        {
            for(var i = 0; i < ToursCount; i++)
            {
                yield return _getTour();
            }
        }

        private IEnumerable<Tuple<int, int>> _getTour()
        {
            var result = new Tuple<int, int>[_players / 2];
            for(var i = 0; i < _players / 2; i+=2)
            {
                result[i] = new Tuple<int, int>(i, i + 1);
            }
            return result;
        }

    }
}
