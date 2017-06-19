using System;
using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface IScoreGameResult
    {
        Tuple<KeyValuePair<IGameUnit, int>, KeyValuePair<IGameUnit, int>> Score { get; }
    }
}