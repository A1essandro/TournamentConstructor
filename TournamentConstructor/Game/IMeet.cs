using System;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public interface IMeet<TResult>
    {
        bool IsComplete { get; }
        Tuple<IGameUnit, IGameUnit> Players { get; }
        TResult Result { get; }
        void SetResult(TResult result);
    }
}