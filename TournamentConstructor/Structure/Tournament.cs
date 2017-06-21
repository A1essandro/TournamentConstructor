using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure
{
    public class Tournament
    {
        public Tournament(IGameUnit[] participants)
        {
            Participants = participants;
        }

        public IGameUnit[] Participants { get; private set; }
    }
}