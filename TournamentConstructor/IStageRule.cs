using System;

namespace TournamentConstructor
{
    public interface IStageRule
    {
        Tuple<int, int>[][] GetSchedule();

        void SetStatuses(IStage stage);
    }
}