using TournamentConstructor.Game;

namespace TournamentConstructor.Rule
{
    public interface IResultFactory
    {

        IResult Calculate(IMatch match, params object[] values);

    }
}