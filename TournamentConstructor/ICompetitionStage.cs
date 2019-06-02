namespace TournamentConstructor
{
    public interface ICompetitionStage : ICompetition
    {
        ICompetition NextStage { get; }

    }
}