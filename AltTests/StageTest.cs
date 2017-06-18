using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentConstructor.GameUnit;
using TournamentConstructor;
using System.Linq;
using TournamentConstructor.Game;

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
            Assert.AreEqual(1, rules.GetSchedule().Length);
            Assert.AreEqual(2, rules.GetSchedule().First().Length);
            Assert.AreEqual(2, rules.GetSchedule()[0][1].Item1);
        }

        [TestMethod]
        public void TestPlayoffStage()
        {
            var units = GetUnits();
            var stage = new Stage(new PlayOffStageRule(2, 1));
            stage.SetUnits(units);
            stage.Start();

            Assert.AreEqual(units.First(), stage.Tours.First().Games.First().Players.Item1);
            Assert.AreEqual(units.Last(), stage.CurrentTour.Games[1].Players.Item2);

            stage.CurrentTour[1].SetResult(new ScoreGameResult(stage.CurrentTour[1], 1, 1));
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
