using System.Collections.Generic;

namespace TournamentConstructor.Championship
{
    public interface ITable
    {
        IReadOnlyCollection<IRow> Rows { get; }
    }
}