using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PeopleContext _context;

        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }

        public async Task CreatePerson(Person person)
        {
            await _context.People.AddAsync(person);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetPeople()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person?> GetPersonById(int id)
        {
            return await _context.People.FindAsync(id);
        }

        public async Task<Person?> GetRandomPerson()
        {
            return await _context.People.OrderBy(x => Guid.NewGuid()).FirstOrDefaultAsync();
        }

        public async Task<bool> DeletePersonById(int id)
        {
            var person = await _context.People.FindAsync(id);

            if (person == null)
                return false;

            _context.People.Remove(person);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
