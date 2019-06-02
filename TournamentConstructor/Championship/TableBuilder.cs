using System.Collections.Generic;

namespace TournamentConstructor.Championship
{
    public class TableBuilder : ITableBuilder
    {

        public Championship Competition { get; }

        public TableBuilder(Championship competition)
        {
            Competition = competition;
        }

        public ITable GetTable()
        {
            Competition.GetOrdered();
            throw new System.NotImplementedException();
        }
    }
}