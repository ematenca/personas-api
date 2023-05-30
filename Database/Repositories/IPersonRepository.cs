using Database.Models;

namespace Database.Repositories
{
    public interface IPersonRepository
    {
        Task CreatePerson(Person person);
        Task<IEnumerable<Person>> GetPeople();
        Task<Person?> GetPersonById(int id);
        Task<Person?> GetRandomPerson();
        Task<bool> DeletePersonById(int id);
    }
}
