using System;
using System.Runtime.CompilerServices;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public class GameResult : IResult
    {

        public GameResult(IMatch game, int a, int b)
        {
            Game = game;
            Points = new Tuple<int, int>(a, b);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsDraw => Points.Item1 == Points.Item2;

        /// <summary>
        /// 
        /// </summary>
        public IGameUnit Winner => Points.Item1 > Points.Item2
                                        ? Game.Teams.Item1
                                        : Points.Item2 > Points.Item1
                                            ? Game.Teams.Item2
                                            : null;

        /// <summary>
        /// 
        /// </summary>
        public IGameUnit Loser => Points.Item1 > Points.Item2
                                        ? Game.Teams.Item2
                                        : Points.Item2 > Points.Item1
                                            ? Game.Teams.Item1
                                            : null;

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public IMatch Game { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public Tuple<int, int> Points { get; }

    }
}