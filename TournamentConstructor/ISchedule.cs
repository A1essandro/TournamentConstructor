using TournamentConstructor.Game;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface ISchedule<TMeetType> where TMeetType : IMeetFact
    {
        ITour<TMeetType>[] Tours { get; }
        Tournament Tournament { get; }
    }
}