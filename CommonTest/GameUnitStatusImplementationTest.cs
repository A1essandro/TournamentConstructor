using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure.Competition;

namespace CommonTest
{
    [TestClass]
    public class GameUnitStatusImplementationTest
    {

        [TestMethod]
        public void TestGameUnitStatus()
        {
            BaseGameUnit gameUnit = "A";
            BaseGameUnit opponent = "B";
            var gameUnitStatus = new GameUnitStatus<Duel>(gameUnit);

            var duel = new Meet<Duel>(gameUnit, opponent);
            duel.SetResult(new Duel(duel, gameUnit));
            gameUnitStatus.AddResult(duel.Result);
            duel = new Meet<Duel>(opponent, gameUnit);
            duel.SetResult(new Duel(duel, opponent));
            gameUnitStatus.AddResult(duel.Result);

            Assert.AreEqual(gameUnit, gameUnitStatus.GameUnit);
            Assert.AreEqual(1, gameUnitStatus.Loses);
            Assert.AreEqual(0, gameUnitStatus.Drafts);
            Assert.AreEqual(1, gameUnitStatus.Wins);
        }

        [TestMethod]
        public void TestSimpleScoredGameUnitStatus()
        {
            BaseGameUnit gameUnit = "A";
            BaseGameUnit opponent1 = "B";
            BaseGameUnit opponent2 = "C";

            var status = new SimpleScoredGameUnitStatus<Match>(gameUnit, 3, 1);

            var match = new Meet<Match>(gameUnit, opponent1);
            match.SetResult(new Match(match, 3, 1));
            status.AddResult(match.Result);

            match = new Meet<Match>(opponent1, gameUnit);
            match.SetResult(new Match(match, 2, 1));
            status.AddResult(match.Result);

            match = new Meet<Match>(gameUnit, opponent2);
            match.SetResult(new Match(match, 1, 1));
            status.AddResult(match.Result);

            match = new Meet<Match>(opponent2, gameUnit);
            match.SetResult(new Match(match, 1, 0));
            status.AddResult(match.Result);

            Assert.AreEqual(gameUnit, status.GameUnit);
            Assert.AreEqual(2, status.Loses);
            Assert.AreEqual(1, status.Drafts);
            Assert.AreEqual(1, status.Wins);
            Assert.AreEqual(4, status.Scores);
        }

        [TestMethod]
        public void TestGoalDiffSimpleScoredGameUnitStatus()
        {
            BaseGameUnit gameUnit = "A";
            BaseGameUnit opponent1 = "B";
            BaseGameUnit opponent2 = "C";

            var status = new GoalDiffSimpleScoredGameUnitStatus(gameUnit, 3, 1);

            var match = new Meet<Match>(gameUnit, opponent1);
            match.SetResult(new Match(match, 5, 1));
            status.AddResult(match.Result);

            match = new Meet<Match>(opponent1, gameUnit);
            match.SetResult(new Match(match, 2, 1));
            status.AddResult(match.Result);

            match = new Meet<Match>(gameUnit, opponent2);
            match.SetResult(new Match(match, 1, 1));
            status.AddResult(match.Result);

            match = new Meet<Match>(opponent2, gameUnit);
            match.SetResult(new Match(match, 1, 0));
            status.AddResult(match.Result);

            Assert.AreEqual(gameUnit, status.GameUnit);
            Assert.AreEqual(2, status.Loses);
            Assert.AreEqual(1, status.Drafts);
            Assert.AreEqual(1, status.Wins);
            Assert.AreEqual(4, status.Scores);
            Assert.AreEqual(2, status.GoalDiff);
        }
    }
}
