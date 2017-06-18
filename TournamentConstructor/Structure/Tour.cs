using TournamentConstructor.Game;

namespace TournamentConstructor.Structure
{
    public class Tour : ITour
    {
        public Duel[] Games { get; private set; }

        public Duel this[int index] => Games[index];

        public Tour(Duel[] games)
        {
            Games = games;
        }

    }
}
