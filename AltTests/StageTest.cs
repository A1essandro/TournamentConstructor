using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentConstructor;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.GameUnit.Status;

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
            var stage = new Stage<Match>(new PlayOffStageRule(2, 2));
            stage.SetUnits(units);
            stage.Start();

            Assert.AreEqual(units.First(), stage.Tours.First().Games.First().Players.Item1);
            Assert.AreEqual(units.Last(), stage.CurrentTour.Games[1].Players.Item2);

            stage.CurrentTour[0].SetResult(new Match(stage.CurrentTour[0], 1, 2));
            stage.CurrentTour[1].SetResult(new Match(stage.CurrentTour[1], 1, 1));
            stage.ToNextTour();
            stage.CurrentTour[0].SetResult(new Match(stage.CurrentTour[0], 1, 0));
            stage.CurrentTour[1].SetResult(new Match(stage.CurrentTour[1], 2, 1));
            stage.Finish();

            /*
             * TODO: key not found
            var mustBe2 = stage.Result.GameUnits.Count(x => x.Status[stage].Any(s => s is PairWinner));
            Assert.AreEqual(2, mustBe2);
            Assert.IsTrue(stage.Result.GameUnits.Single(u => u.Name == "B").Status[stage].Any(s => s is PairWinner));
            */
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