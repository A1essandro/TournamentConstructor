using System;
using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public class Game : IMatch
    {

        private Tuple<int, int> _points;

        public Game(IGameUnit a, IGameUnit b)
            : this(new Tuple<IGameUnit, IGameUnit>(a, b))
        {
        }

        public Game(Tuple<IGameUnit, IGameUnit> units)
        {
            Teams = units;
        }

        public bool HasResult => !(Result is null);

        public IGameResult Result => new GameResult(this, _points.Item1, _points.Item2);

        public Tuple<IGameUnit, IGameUnit> Teams { get; }

        public void SetPoints(Tuple<int, int> points) => _points = points;

        public void SetPoints(int a, int b) => _points = new Tuple<int, int>(a, b);

    }
}