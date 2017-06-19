using System;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    internal class Schedule : ISchedule
    {
        private Tour[] tour;

        public Schedule(Tour[] tour)
        {
            this.tour = tour;
        }

        public Tournament Tournament
        {
            get { throw new NotImplementedException(); }
        }

        public ITour[] Tours
        {
            get { throw new NotImplementedException(); }
        }
    }
}