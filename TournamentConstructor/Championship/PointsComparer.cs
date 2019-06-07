using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TournamentConstructor.Championship
{
    public class PointsComparer : ComparerBase
    {

        public override int Compare(IParticipant x, IParticipant y)
        {
            return _calculatePoints(y) - _calculatePoints(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int _calculatePoints(IParticipant participant)
        {
            var points = GetParticipangGames(participant)
                .Select(m => m.Result.Winner == participant.Team
                                ? 3
                                : m.Result.IsDraw
                                    ? 1
                                    : 0)
                .Sum();

            return points;
        }

    }
}