using System.Collections.Generic;

namespace TournamentConstructor.GameUnit
{
    public class BaseGameUnit : IGameUnit
    {
        public BaseGameUnit(string name)
        {
            Name = name;
            Status = new Dictionary<ITournament, IList<IStageStatus>>();
        }

        public string Name { get; }

        public IDictionary<ITournament, IList<IStageStatus>> Status { get; }

        public void AddStatus(ITournament stage, IStageStatus status)
        {
            if (!Status.ContainsKey(stage))
                Status[stage] = new List<IStageStatus>();
            Status[stage].Add(status);
        }

        public static implicit operator BaseGameUnit(string name)
        {
            return new BaseGameUnit(name);
        }

    }
}