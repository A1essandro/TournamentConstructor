using System.Collections.Generic;

namespace TournamentConstructor.GameUnit
{
    public class BaseGameUnit : IGameUnit
    {
        public BaseGameUnit(string name)
        {
            Name = name;
            Status = new Dictionary<IStage, IList<IStageStatus>>();
        }

        public string Name { get; }

        public IDictionary<IStage, IList<IStageStatus>> Status { get; }

        public void AddStatus(IStage stage, IStageStatus status)
        {
            if(!Status.ContainsKey(stage))
                Status[stage] = new List<IStageStatus>();
            Status[stage].Add(status);
        }
    }
}