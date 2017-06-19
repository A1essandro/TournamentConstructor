using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public interface IToss
    {
        ISchedule ToToss(Tournament tournament);
    }
}