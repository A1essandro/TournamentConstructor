using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface IStage : ITournament
    {

        IStageResult Result { get; }

        ITour CurrentTour { get; }

        void Start();

        void SetNextStage(IStage next);

        void ToNextStage();

        void ToNextTour();

    }
}
