using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentConstructor;

namespace CommonTest
{
    [TestClass]
    public class TableTest
    {
        [TestMethod]
        public void Rows()
        {
            var A = new BaseGameUnit("A");
            var B = new BaseGameUnit("B");
            var C = new BaseGameUnit("C");
            var D = new BaseGameUnit("D");

            var teams = new BaseGameUnit[4] { A, B, C, D };

            var table = new Table<Row>(teams, t => new Row(t));
            Assert.AreEqual(table.Rows.Length, teams.Length);
        }
    }
}
