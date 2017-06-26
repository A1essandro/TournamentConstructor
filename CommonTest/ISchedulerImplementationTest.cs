using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TournamentConstructor.Structure.Competition;

namespace CommonTest
{
    [TestClass]
    public class ISchedulerImplementationTest
    {
        [TestMethod]
        public void TestPlayoffScheduler()
        {
            var scheduler = new PlayoffShceduler(2);
            var tours = scheduler.GetTours();
            var firstMeetMustBe = new Tuple<int, int>(0, 1);

            Assert.AreEqual(2, scheduler.ToursCount);
            Assert.AreEqual(2, tours.ToArray().Length);
            Assert.AreEqual(1, tours.First().ToArray().Length);
            Assert.AreEqual(firstMeetMustBe, tours.First().Single());
        }
    }
}
