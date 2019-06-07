using System.Collections.Generic;

namespace TournamentConstructor.GameUnit
{
    public class Team : IGameUnit
    {

        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static implicit operator Team(string name) => new Team(name);

    }
}