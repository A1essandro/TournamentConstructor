using System.Collections.Generic;
using System.Linq;

namespace TournamentConstructor.Championship
{
    public class PointsComparer : IComparer<IParticipant>
    {

        public int Compare(IParticipant x, IParticipant y)
        {
            var competition = x.Competition;
            var xMatches = competition.Matches
                .Where(m => m.HasResult)
                .Where(m => m.Teams.Item1 == x || m.Teams.Item2 == x);
            var pointsX = xMatches.Select(m => m.Result.Winner == x ? 3 : m.Result.IsDraw ? 1 : 0).Sum();

            var yMatches = competition.Matches
                .Where(m => m.HasResult)
                .Where(m => m.Teams.Item1 == y || m.Teams.Item2 == y);
            var pointsY = yMatches.Select(m => m.Result.Winner == y ? 3 : m.Result.IsDraw ? 1 : 0).Sum();

            return pointsX - pointsY;
        }

    }
}