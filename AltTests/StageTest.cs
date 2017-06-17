using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentConstructor.GameUnit;
using TournamentConstructor;

namespace AltTests
{
    [TestClass]
    public class StageTest
    {
        [TestMethod]
        public void TestPlayoffRules()
        {
            var rules = new PlayOffStageRule(2, 1);
            var t = rules.GetSchedule();
            Assert.AreEqual(2, rules.GetSchedule()[0][1].Item1);
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
