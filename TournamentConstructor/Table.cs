using System;

namespace TournamentConstructor
{
    public class Table<TRow>
    {

        public TRow[] Rows { get; protected set; }

        public Table(IGameUnit[] units, Func<IGameUnit, TRow> foo)
        {
            Rows = new TRow[units.Length];
            var i = 0;
            foreach (var unit in units)
            {
                Rows[i++] = foo(unit);
            }
        }

        public Table(TRow[] rows)
        {
            Rows = rows;
        }

    }
}