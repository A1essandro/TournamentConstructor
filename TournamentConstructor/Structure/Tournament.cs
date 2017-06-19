using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure
{
    public class Tournament
    {
        public Tournament(IGameUnit[] participants, IToss toss)
        {
            Participants = participants;
        }

        public IGameUnit[] Participants { get; private set; }
        protected IToss _toss { get; private set; }

        public void Toss()
        {
            _toss.ToToss(this);
        }
    }
}