using System.Linq;
using TournamentConstructor.Championship;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using Xunit;

namespace SamplesTests
{
    public class ChampionshipTest
    {

        [Fact]
        public void OrderTest()
        {
            Team a = "Arsenal";
            Team b = "Bayern";
            Team c = "Celtic";
            Team d = "Deportivo";

            var games = new Game[] {
                new Game(a, b), new Game(c, d),
                new Game(a, c), new Game(b, d),
                new Game(a, d), new Game(b, c)
            };
            //                               g.diff  pts
            games[0].SetPoints(1, 0); //A-B,  1:-1,  3:0
            games[1].SetPoints(1, 1); //C-D,  0: 0,  1:1
            games[2].SetPoints(2, 2); //A-C,  1: 0,  4:2
            games[3].SetPoints(1, 0); //B-D,  0:-1,  3:1
            games[4].SetPoints(2, 5); //A-D, -2: 2,  4:4
            games[5].SetPoints(4, 0); //B-C,  4:-4,  6:2

            var comparers = new ComparerBase[] { new PointsComparer(), new GoalsDiffComparer() };
            var championship = new Championship(games, comparers);

            var test = championship.GetOrdered();

            Assert.Equal(b, test[0].GameUnit);
            Assert.Equal(d, test[1].GameUnit);
            Assert.Equal(a, test[2].GameUnit);
            Assert.Equal(c, test[3].GameUnit);
        }

    }
}