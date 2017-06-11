using System;
using System.Linq;

namespace TournamentConstructor.Structure
{
    public class Championship<TRow> : Tournament
        where TRow : Row
    {

        public Table<TRow> Table { get; protected set; }
        public ISchedule Schedule { get; protected set; }

        public Championship(IGameUnit[] participants, Func<IGameUnit, TRow> foo)
            : base(participants)
        {
            Table = new Table<TRow>(participants, foo);
        }

        public Championship(Table<TRow> table) 
            : base(table.Rows.Select(x => x.GameUnit).ToArray())
        {
            Table = table;
        }

    }
}
