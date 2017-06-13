namespace TournamentConstructor
{
    public abstract class Stage : IStage
    {

        protected IStageRule Rule;

        public IStage NextStage { get; private set; }

        public IGameUnitWithStatus[] GameUnits { get; private set; }

        public IStageResult Result { get; protected set; }

        protected Stage(IStageRule rule)
        {
            Rule = rule;
        }

        public void SetUnits(IGameUnitWithStatus[] units)
        {
            GameUnits = units;
        }

        public void SetNextStage(IStage next)
        {
            NextStage = next;
        }

        public abstract bool IsComplete();

        public abstract void ToNextStage();

        public abstract void ToNextTour();
    }
}
