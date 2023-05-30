using Database.Models;

namespace Database
{
    public static class DbInitialize
    {
        public static void Initialize(PeopleContext peopleContext) 
        {
            if (peopleContext.People.Any())
                return;

            var person = new Person[]
            {
                new Person { Name = "Juan" },
                new Person { Name = "Jose" },
                new Person { Name = "Nahuel" },
                new Person { Name = "Matias" },
                new Person { Name = "Leandro" },
                new Person { Name = "Ezequiel" },
                new Person { Name = "Eduardo" },
                new Person { Name = "Jorge" },
                new Person { Name = "Lucas" },
                new Person { Name = "Lautaro" }
            };

            foreach (Person p in person)
                peopleContext.Add(p);

            peopleContext.SaveChanges();
        }
    }
}
