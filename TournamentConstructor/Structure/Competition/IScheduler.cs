using System;
using System.Collections.Generic;

namespace TournamentConstructor.Structure.Competition
{
    public interface IScheduler
    {

        IEnumerable<IEnumerable<Tuple<int, int>>> GetTours();

        ushort ToursCount { get; }

    }
}