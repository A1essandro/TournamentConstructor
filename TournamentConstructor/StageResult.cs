using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public class StageResult : IStageResult
    {
        public StageResult(IEnumerable<IGameUnit> units)
        {
            GameUnits = units.ToArray();
        }

        public IGameUnit[] GameUnits { get; }
    }
}