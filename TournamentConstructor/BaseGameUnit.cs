namespace TournamentConstructor
{
    public class BaseGameUnit : IGameUnit
    {
        public string Name { get; private set; }

        public BaseGameUnit(string name)
        {
            Name = name;
        }

    }
}
