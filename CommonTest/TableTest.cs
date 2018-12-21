using Xunit;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure;
using Moq;

namespace CommonTest
{
    public class TableTest
    {
        [Fact]
        public void Rows()
        {
            var A = new Mock<IGameUnit>();
            var B = new Mock<IGameUnit>();
            var C = new Mock<IGameUnit>();
            var D = new Mock<IGameUnit>();

            var teams = new IGameUnit[4] {A.Object, B.Object, C.Object, D.Object};

            var table = new Table<Row>(teams, t => new Row(t));
            Assert.Equal(table.Rows.Length, teams.Length);
        }
    }
}