namespace TournamentConstructor
{
    public interface IStage : ITournament
    {

        IStageResult Result { get; }

        void SetNextStage(IStage next);

        void ToNextStage();

        void ToNextTour();

    }
}
