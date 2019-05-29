using Moq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using Xunit;

namespace CommonTest
{
    public class MatchTest
    {

        [Fact]
        public void WinnerTest()
        {
            var a = new Mock<IGameUnit>();
            var b = new Mock<IGameUnit>();
            var result = new Mock<IResult>();

            var match = new TournamentConstructor.Game.Match(a.Object, b.Object);
            match.Result = result.Object;
        }

    }
}