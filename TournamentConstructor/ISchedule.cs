using TournamentConstructor.Game;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface ISchedule<TMeetType>
    {
        ITour<TMeetType>[] Tours { get; }
        Tournament Tournament { get; }
    }
}