using TournamentConstructor.Game;

namespace TournamentConstructor.Structure
{
    public class Tour : ITour
    {
        public Duel[] Games { get; private set; }

        public Tour(Duel[] games)
        {
            Games = games;
        }

    }
}
