using System;
using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Rule
{
    public interface IStageRule<TMeetType>
        where TMeetType : IMeetFact
    {

        ushort PassCount { get; }

        Tuple<int, int>[][] GetSchedule();

        void SetStatuses(IStage<TMeetType> stage);

        IEnumerable<IGameUnit> GetPassing(IStage<TMeetType> stage);
    }
}