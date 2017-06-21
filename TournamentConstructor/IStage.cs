using TournamentConstructor.Game;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface IStage<TMeetFact> : ITournament where TMeetFact : IMeetFact
    {
        IStageResult Result { get; }

        ITour<TMeetFact>[] Tours { get; }

        ITour<TMeetFact> CurrentTour { get; }

        void SetNextStage(IStage<TMeetFact> next);

        void ToNextStage();

        void ToNextTour();
    }
}