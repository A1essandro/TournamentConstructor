using System;
using System.Linq;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure
{
    public class Table<TRow> where TRow : Row
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

        public IGameUnit[] GetParticipants()
        {
            return Rows.Select(x => x.GameUnit).ToArray();
        }

    }
}