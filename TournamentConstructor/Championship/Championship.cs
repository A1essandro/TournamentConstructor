using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;

namespace TournamentConstructor.Championship
{
    public class Championship : Competition
    {
        public Championship(IEnumerable<IMatch> matches, IEnumerable<IComparer<IParticipant>> comparers)
            : base(matches)
        {
            Comparers = comparers.ToArray();
        }

        public IEnumerable<IComparer<IParticipant>> Comparers { get; }

        public IParticipant[] GetOrdered()
        {
            var result = Participants.AsEnumerable();
            foreach (var comparer in Comparers)
            {
                result = result.OrderByDescending(participant => participant, comparer);
            }

            return result.ToArray();
        }

    }
}