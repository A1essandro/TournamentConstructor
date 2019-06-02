namespace TournamentConstructor
{
    public interface ICompositeCompetition : ICompetition
    {

        ICompetition[] InnerCompetitions { get; }

    }
}