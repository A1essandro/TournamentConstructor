using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TournamentConstructor;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure;

namespace CommonTest
{
    [TestClass]
    public class ChampionshipTest
    {
        [TestMethod]
        public void ConstructorViaTeams()
        {
            var toss = new ChampionshipStandartToss();
            var teams = GetUnits();
            var champ = new Championship<Row>(teams, t => new Row(t), toss);

            Assert.AreEqual(champ.Table.Rows.First().GameUnit, teams.First());
        }

        [TestMethod]
        public void ConstructorViaTable()
        {
            var toss = new ChampionshipStandartToss();
            var teams = GetUnits();
            var table = new Table<Row>(teams, x => new Row(x));
            var champ = new Championship<Row>(table, toss);

            Assert.AreEqual(champ.Table.Rows.First().GameUnit, teams.First());
        }

        private static BaseGameUnit[] GetUnits()
        {
            var A = new BaseGameUnit("A");
            var B = new BaseGameUnit("B");
            var C = new BaseGameUnit("C");
            var D = new BaseGameUnit("D");

            return new BaseGameUnit[4] { A, B, C, D };
        }
    }
}
