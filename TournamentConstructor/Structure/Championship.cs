using System;
using System.Linq;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure
{
    public class Championship<TRow> : Tournament
        where TRow : Row
    {
        public Championship(IGameUnit[] participants, Func<IGameUnit, TRow> foo, IToss toss)
            : base(participants, toss)
        {
            Table = new Table<TRow>(participants, foo);
        }

        public Championship(Table<TRow> table, IToss toss)
            : base(table.Rows.Select(x => x.GameUnit).ToArray(), toss)
        {
            Table = table;
        }

        public Table<TRow> Table { get; protected set; }
        public ISchedule Schedule { get; protected set; }
    }
}