using System;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public class ChampionshipStandartToss : IToss
    {
        public ISchedule ToToss(Tournament tournament)
        {
            var part1 = tournament.Participants.Take(tournament.Participants.Length/2).ToArray();
            var part2 = tournament.Participants.Skip(tournament.Participants.Length/2).ToArray();

            var tours = new Tour[(tournament.Participants.Length - 1)*2];
            var tourIndex = 0;

            while (tours.Last() == null)
            {
                var tourGames = new Duel[tournament.Participants.Length/2];
                for (var i = 0; i < tournament.Participants.Length/2; i++)
                {
                    tourGames[i] = new Duel(new Tuple<IGameUnit, IGameUnit>(part1[i], part2[i]));
                }
                tours[tourIndex++] = new Tour(tourGames);

                PartsCycleStep(part1, part2);
            }

            return new Schedule(tours.ToArray());
        }

        protected void PartsCycleStep(IGameUnit[] part1, IGameUnit[] part2)
        {
            var from2to1 = part2[0];
            var from1to2 = part1[part1.Length - 1];

            for (var i = part1.Length - 1; i != 0; --i)
                part1[i] = part1[i - 1];

            for (var i = 0; i < part2.Length - 1; ++i)
                part2[i] = part2[i + 1];

            part1[0] = from2to1;
            part2[part2.Length - 1] = from1to2;
        }
    }
}