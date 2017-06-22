using TournamentConstructor.Game;
using TournamentConstructor.Rule;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface IStage<TMeetFact> : ITournament where TMeetFact : IMeetFact
    {
        IStageResult Result { get; }

        IStageRule<TMeetFact> Rule { get; }

        ITour<TMeetFact>[] Tours { get; }

        ITour<TMeetFact> CurrentTour { get; }

        void SetNextStage(IStage<TMeetFact> next);

        IStage<TMeetFact> ToNextStage();

        void ToNextTour();

    }
}