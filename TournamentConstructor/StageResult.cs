using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public class StageResult : IStageResult
    {
        public IGameUnit[] GameUnits { get; }

        public StageResult(IEnumerable<IGameUnit> units)
        {
            GameUnits = units.ToArray();
        }

    }
}