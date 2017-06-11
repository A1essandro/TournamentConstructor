using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TournamentConstructor;
using TournamentConstructor.Structure;

namespace CommonTest
{
    [TestClass]
    public class ChampionshipTest
    {
        [TestMethod]
        public void ConstructorViaTeams()
        {
            var A = new BaseGameUnit("A");
            var B = new BaseGameUnit("B");
            var C = new BaseGameUnit("C");
            var D = new BaseGameUnit("D");

            var teams = new BaseGameUnit[4] { A, B, C, D };
            var champ = new Championship<Row>(teams, t => new Row(t));

            Assert.AreEqual(champ.Table.Rows.First().GameUnit, A);
        }

        [TestMethod]
        public void ConstructorViaTable()
        {
            var A = new BaseGameUnit("A");
            var B = new BaseGameUnit("B");
            var C = new BaseGameUnit("C");
            var D = new BaseGameUnit("D");

            var teams = new BaseGameUnit[4] { A, B, C, D };
            var table = new Table<Row>(teams, x => new Row(x));
            var champ = new Championship<Row>(table);

            Assert.AreEqual(champ.Table.Rows.First().GameUnit, A);
        }
    }
}
