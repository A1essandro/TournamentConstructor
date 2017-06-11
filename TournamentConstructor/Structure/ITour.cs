namespace TournamentConstructor.Structure
{
    public interface ITour
    {

        Duel[] Games { get; }
        ISchedule Schedule { get; }

    }
}
