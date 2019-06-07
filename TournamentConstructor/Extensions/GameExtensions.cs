using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Extensions
{
    public static class GameExtensions
    {

        public static IReadOnlyDictionary<IGameUnit, int> GetPointsByPlayers(this IMatch game)
        {
            return new Dictionary<IGameUnit, int>(){
                { game.Teams.Item1, game.Result.Points.Item1 },
                { game.Teams.Item2, game.Result.Points.Item2 }
            };
        }

    }
}