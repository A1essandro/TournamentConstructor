namespace TournamentConstructor.Structure
{
    public class Tournament
    {

        public IGameUnit[] Participants { get; private set; }

        public Tournament(IGameUnit[] participants)
        {
            Participants = participants;
        }

    }
}
