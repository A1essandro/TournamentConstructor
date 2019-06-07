using System;
using System.Linq;
using Moq;
using TournamentConstructor.Championship;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnits;
using Xunit;

namespace UnitTests
{
    public class ChampionshipTest
    {

        [Fact]
        public void OrderTest()
        {
            var a = new Mock<ITeam>();
            a.SetupGet(x => x.Name).Returns("A");
            var b = new Mock<ITeam>();
            b.SetupGet(x => x.Name).Returns("B");
            var c = new Mock<ITeam>();
            c.SetupGet(x => x.Name).Returns("C");

            var games = new Mock<IGame>[] { new Mock<IGame>(), new Mock<IGame>(), new Mock<IGame>() };

            games[0].SetupGet(x => x.Teams).Returns(new Tuple<ITeam, ITeam>(a.Object, b.Object));
            games[1].SetupGet(x => x.Teams).Returns(new Tuple<ITeam, ITeam>(a.Object, c.Object));
            games[2].SetupGet(x => x.Teams).Returns(new Tuple<ITeam, ITeam>(b.Object, c.Object));

            games[0].SetupGet(x => x.Result).Returns(_getResultMock(a.Object, b.Object, 1, 0));
            games[0].SetupGet(x => x.HasResult).Returns(true);
            games[1].SetupGet(x => x.Result).Returns(_getResultMock(a.Object, c.Object, 3, 3));
            games[1].SetupGet(x => x.HasResult).Returns(true);
            games[2].SetupGet(x => x.Result).Returns(_getResultMock(b.Object, c.Object, 1, 1));
            games[2].SetupGet(x => x.HasResult).Returns(true);

            var comparers = new[] { new PointsComparer() }; //TODO: make mock
            var championship = new Championship(games.Select(x => x.Object), comparers);
            var test = championship.GetOrdered();

            Assert.Equal(a.Object, test[0].Team);
            Assert.Equal(c.Object, test[1].Team);
            Assert.Equal(b.Object, test[2].Team);
        }

        private IGameResult _getResultMock(ITeam player1, ITeam player2, int player1Points, int player2Points)
        {
            var mock = new Mock<IGameResult>();
            if (player1Points != player2Points)
            {
                mock.SetupGet(x => x.Winner).Returns(player1Points > player2Points ? player1 : player2);
                mock.SetupGet(x => x.Loser).Returns(player1Points > player2Points ? player2 : player1);
            }
            else
            {
                mock.SetupGet(x => x.IsDraw).Returns(true);
            }

            return mock.Object;
        }

    }
}