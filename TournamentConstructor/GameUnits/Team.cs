using System.Collections.Generic;

namespace TournamentConstructor.GameUnits
{
    public class Team : ITeam
    {

        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static implicit operator Team(string name) => new Team(name);

    }
}