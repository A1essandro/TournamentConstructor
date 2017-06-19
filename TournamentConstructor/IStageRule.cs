using System;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface IStageRule
    {

        Tuple<int, int>[][] GetSchedule();

        void SetStatuses(ITour[] tours);

    }
}