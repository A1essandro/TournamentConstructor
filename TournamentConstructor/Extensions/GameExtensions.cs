using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnits;

namespace TournamentConstructor.Extensions
{
    public static class GameExtensions
    {

        public static IReadOnlyDictionary<ITeam, int> GetPointsByPlayers(this IGame game)
        {
            return new Dictionary<ITeam, int>(){
                { game.Teams.Item1, game.Result.Points.Item1 },
                { game.Teams.Item2, game.Result.Points.Item2 }
            };
        }

    }
}