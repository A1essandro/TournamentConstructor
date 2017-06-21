using System;
using TournamentConstructor.Game;

namespace TournamentConstructor
{
    public interface IStageRule
    {
        Tuple<int, int>[][] GetSchedule();

        void SetStatuses<TMeetType>(IStage<TMeetType> stage);
    }
}