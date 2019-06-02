using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public abstract class Competition : ICompetition
    {

        protected Competition(IEnumerable<IMatch> matches)
        {
            Matches = matches.ToArray();
            Participants = Matches.SelectMany(x => new[] { x.Teams.Item1, x.Teams.Item2 })
                           .Distinct()
                           .Select(x => new Participant(this, x))
                           .ToArray();
        }

        public virtual IEnumerable<IMatch> Matches { get; }

        public virtual IEnumerable<IParticipant> Participants { get; }

        public virtual bool IsCompleted => Matches.All(x => x.HasResult);

    }
}