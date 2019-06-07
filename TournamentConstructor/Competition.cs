using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnits;

namespace TournamentConstructor
{
    public abstract class Competition : ICompetition
    {

        protected Competition(IEnumerable<IGame> matches)
        {
            Matches = matches.ToArray();
            Participants = Matches.SelectMany(x => new[] { x.Teams.Item1, x.Teams.Item2 })
                           .Distinct()
                           .Select(x => new Participant(this, x))
                           .ToArray();
        }

        public virtual IEnumerable<IGame> Matches { get; }

        public virtual IEnumerable<IParticipant> Participants { get; }

        public virtual bool IsCompleted => Matches.All(x => x.HasResult);

    }
}