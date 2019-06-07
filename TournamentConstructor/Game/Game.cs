using System;
using System.Collections.Generic;
using TournamentConstructor.GameUnits;

namespace TournamentConstructor.Game
{
    public class Game : IGame
    {

        private Tuple<int, int> _points;

        public Game(ITeam a, ITeam b)
            : this(new Tuple<ITeam, ITeam>(a, b))
        {
        }

        public Game(Tuple<ITeam, ITeam> units)
        {
            Teams = units;
        }

        public bool HasResult => !(Result is null);

        public IGameResult Result => new GameResult(this, _points.Item1, _points.Item2);

        public Tuple<ITeam, ITeam> Teams { get; }

        public void SetPoints(Tuple<int, int> points) => _points = points;

        public void SetPoints(int a, int b) => _points = new Tuple<int, int>(a, b);

    }
}