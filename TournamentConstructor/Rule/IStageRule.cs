using System;
using TournamentConstructor.Game;

namespace TournamentConstructor.Rule
{
    public interface IStageRule<TMeetType>
        where TMeetType : IMeetFact
    {
        Tuple<int, int>[][] GetSchedule();

        void SetStatuses(IStage<TMeetType> stage);
    }
}