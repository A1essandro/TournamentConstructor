using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;

namespace TournamentConstructor.Championship
{
    public class Championship : Competition
    {
        public Championship(IEnumerable<IMatch> matches, IEnumerable<IComparer<IParticipant>> comparators)
            : base(matches)
        {
            Comparers = comparators.ToArray();
        }

        public IEnumerable<IComparer<IParticipant>> Comparers { get; }

        public IReadOnlyCollection<IParticipant> GetOrdered()
        {
            var result = Participants.AsEnumerable();
            foreach (var comparer in Comparers)
            {
                result = result.OrderBy(p => comparer);
            }

            return result.ToArray();
        }

    }
}