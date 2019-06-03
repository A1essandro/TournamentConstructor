using System.Collections.Generic;
using System.Linq;

namespace TournamentConstructor.Championship
{
    public class PointsComparer : IComparer<IParticipant>
    {

        public int Compare(IParticipant x, IParticipant y)
        {
            return _calculatePoints(x) - _calculatePoints(y);
        }

        private int _calculatePoints(IParticipant participant)
        {
            var player = participant.GameUnit;
            var participantGames = participant.Competition.Matches
                .Where(m => m.HasResult)
                .Where(m => m.Teams.Item1 == player || m.Teams.Item2 == player);
            return participantGames.Select(m => m.Result.Winner == player
                                                    ? 3
                                                    : m.Result.IsDraw
                                                        ? 1
                                                        : 0).Sum();
        }

    }
}