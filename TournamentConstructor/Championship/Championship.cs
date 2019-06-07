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
                if (result is IOrderedEnumerable<IParticipant>)
                {
                    result = (result as IOrderedEnumerable<IParticipant>).ThenBy(participant => participant, comparer);
                }
                else
                {
                    result = result.OrderBy(participant => participant, comparer);
                }
            }

            var r = result.ToList();
            return result.ToArray();
        }

    }
}