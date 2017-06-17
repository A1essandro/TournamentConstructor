using System.Collections.Generic;

namespace TournamentConstructor.GameUnit
{
    public class BaseGameUnit : IGameUnitWithStatus
    {
        public string Name { get; private set; }

        public IDictionary<IStage, IList<IStageStatus>> Status { get; private set; }

        public BaseGameUnit(string name)
        {
            Name = name;
        }

        public void AddStatus(IStage stage, IStageStatus status)
        {
            Status[stage].Add(status);
        }

    }
}
