using System;
using System.Collections.Generic;

namespace TournamentConstructor.Structure.Competition.Scheduler
{
    public interface IScheduler
    {

        IEnumerable<IEnumerable<Tuple<int, int>>> GetTours();

        ushort ToursCount { get; }

    }
}