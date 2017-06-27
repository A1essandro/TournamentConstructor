using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.GameUnit.Position;
using TournamentConstructor.Structure.Competition;
using TournamentConstructor.Structure.Competition.Scheduler;

namespace CommonTest
{
    [TestClass]
    public class CompetitionImplementationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new BaseGameUnit("A");
            var b = new BaseGameUnit("B");
            var units = new GoalDiffSimpleScoredPosition[] {
                new GoalDiffSimpleScoredPosition(a, 3, 1, 0),
                new GoalDiffSimpleScoredPosition(b, 3, 1, 0),
            };
            var competition = new ScoredCompetition(new PlayoffShceduler(), units);

            var meet = competition.Tours.Single().Games.Single();
            meet.SetResult(new Match(meet, 3, 1));
            competition.Units.Where(x => x.GameUnit == a).Single().AddResult(meet.Result);
            competition.Units.Where(x => x.GameUnit == b).Single().AddResult(meet.Result);

            Assert.Equals(a, competition.Units.First());
        }
    }
}
