using System;
using System.Collections.Generic;

namespace TournamentConstructor.Structure.Competition
{
    public class PlayoffShceduler : IScheduler
    {

        public PlayoffShceduler(ushort meets = 1)
        {
            ToursCount = meets;
        }

        public ushort ToursCount { get; private set; }

        public IEnumerable<IEnumerable<Tuple<int, int>>> GetTours()
        {
            for(var i = 0; i < ToursCount; i++)
            {
                yield return (i % 2 == 0)
                    ? new[] { new Tuple<int, int>(0, 1) }
                    : new[] { new Tuple<int, int>(1, 0) };
            }
        }
    }
}
