using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface ISchedule
    {

        ITour[] Tours { get; }
        Tournament Tournament { get; }

        ITour GetNext();

    }
}
