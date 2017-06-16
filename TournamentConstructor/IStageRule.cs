using System;

namespace TournamentConstructor
{
    public interface IStageRule
    {

        Tuple<int, int>[][] GetSchedule();

    }
}