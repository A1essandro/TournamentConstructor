using System;
using TournamentConstructor.Game;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    internal class Schedule<TMeetType> : ISchedule<TMeetType> where TMeetType : IMeetFact
    {
        private ITour<TMeetType>[] tour;

        public Schedule(ITour<TMeetType>[] tour)
        {
            this.tour = tour;
        }

        public Tournament Tournament
        {
            get { throw new NotImplementedException(); }
        }

        public ITour<TMeetType>[] Tours
        {
            get { throw new NotImplementedException(); }
        }
    }
}