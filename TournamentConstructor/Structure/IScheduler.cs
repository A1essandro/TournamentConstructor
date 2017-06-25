﻿using System;
using System.Collections.Generic;

namespace TournamentConstructor.Structure
{
    public interface IScheduler
    {

        IEnumerable<IEnumerable<Tuple<int, int>>> GetTours();

        uint ToursCount { get; }

    }
}