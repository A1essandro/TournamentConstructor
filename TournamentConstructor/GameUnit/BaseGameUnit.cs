using System.Collections.Generic;

namespace TournamentConstructor.GameUnit
{
    public class BaseGameUnit : IGameUnit
    {
        public BaseGameUnit(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public IDictionary<IStage, IList<IStageStatus>> Status { get; private set; }

        public void AddStatus(IStage stage, IStageStatus status)
        {
            Status[stage].Add(status);
        }
    }
}