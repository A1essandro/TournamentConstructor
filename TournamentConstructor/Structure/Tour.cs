using TournamentConstructor.Game;

namespace TournamentConstructor.Structure
{
    public class Tour : ITour
    {
        public Tour(Duel[] games)
        {
            Games = games;
        }

        public Duel[] Games { get; }

        public Duel this[int index] => Games[index];
    }
}