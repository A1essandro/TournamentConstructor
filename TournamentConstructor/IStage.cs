using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface IStage<TMeetFact> : ITournament
    {
        IStageResult Result { get; }

        ITour<TMeetFact>[] Tours { get; }

        ITour<TMeetFact> CurrentTour { get; }

        void SetNextStage(IStage<TMeetFact> next);

        IStage<TMeetFact> ToNextStage();

        void ToNextTour();

    }
}