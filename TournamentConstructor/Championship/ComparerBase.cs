using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;

namespace TournamentConstructor.Championship
{
    public abstract class ComparerBase : IComparer<IParticipant>
    {
        public abstract int Compare(IParticipant x, IParticipant y);

        protected IEnumerable<IMatch> GetParticipangGames(IParticipant participant)
        {
            var player = participant.GameUnit;
            return participant.Competition.Matches
                .Where(m => m.HasResult)
                .Where(m => m.Teams.Item1 == player || m.Teams.Item2 == player);
        }

    }
}