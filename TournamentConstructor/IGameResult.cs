namespace TournamentConstructor
{
    public interface IGameResult
    {

        bool IsDraft { get; }

        IGameUnit Winner { get; }

        IGameUnit Loser { get; }

    }
}
