using System.Collections.Generic;
using System.Linq;
using Bogus;
using WebServiceDemo.Entities;

namespace WebServiceDemo.Helpers
{
    public static class DummyDataStore
    {
        private static int _currentPersonId = 0;
        private static int _currentTeamId = 0;

        public static List<Team> Teams { get; private set; }

        public static void GenerateData()
        {
            var dummyCoach = new Faker<Coach>()
                .AddPersonProperties()
                .RuleFor(p => p.Strategy, f => f.PickRandom<CoachingStrategy>());

            var dummyPlayer = new Faker<Player>()
                .AddPersonProperties()
                .RuleFor(p => p.Position, f => f.PickRandom<Position>());

            var dummyTeams = new Faker<Team>()
                .RuleFor(t => t.Name, f => f.Company.CompanyName())
                .RuleFor(t => t.TeamId, f => SimulateIncrementedDbId(ref _currentTeamId))
                .RuleFor(t => t.Players, f => dummyPlayer.Generate(12).ToList())
                .RuleFor(t => t.Coach, f => dummyCoach.Generate(1)[0]);

            Teams = dummyTeams.Generate(20).ToList();
        }

        private static Faker<T> AddPersonProperties<T>(this Faker<T> person) where T : Entities.Person
        {
            return person
                .RuleFor(p => p.PersonId, f => SimulateIncrementedDbId(ref _currentPersonId))
                .RuleFor(p => p.BirthDate, f => f.Date.Past())
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName());
        }

        private static int SimulateIncrementedDbId(ref int index)
        {
            var toReturn = index;
            index += 1;
            return toReturn;
        }
    }
}
