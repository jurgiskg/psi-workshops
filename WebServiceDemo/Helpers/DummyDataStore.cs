using System.Collections.Generic;
using System.Linq;
using Bogus;
using WebServiceDemo.Entities;

namespace WebServiceDemo.Helpers
{
    public static class DummyDataStore
    {
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
                .RuleFor(t => t.TeamId, f => f.Random.Number())
                .RuleFor(t => t.Players, f => dummyPlayer.Generate(12).ToList())
                .RuleFor(t => t.Coach, f => dummyCoach.Generate(1)[0]);

            Teams = dummyTeams.Generate(20).ToList();
        }

        private static Faker<T> AddPersonProperties<T>(this Faker<T> person) where T : Entities.Person
        {
            return person
                .RuleFor(p => p.PersonId, f => f.Random.Number())
                .RuleFor(p => p.BirthDate, f => f.Date.Past())
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName());
        }
    }
}
