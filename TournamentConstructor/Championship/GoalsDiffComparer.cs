using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TournamentConstructor.Extensions;
using TournamentConstructor.Game;

namespace TournamentConstructor.Championship
{
    public class GoalsDiffComparer : ComparerBase
    {

        public override int Compare(IParticipant x, IParticipant y)
        {
            return _calculateGoals(y) - _calculateGoals(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int _calculateGoals(IParticipant participant)
        {
            var goals = GetParticipangGames(participant)
                .Select(x =>
                {
                    var points = x.GetPointsByPlayers();
                    var positive = points[participant.GameUnit];
                    var negative = points.Where(y => y.Key != participant.GameUnit).Sum(y => y.Value);
                    return positive - negative;
                })
                .Sum();

            return goals;
        }

    }
}