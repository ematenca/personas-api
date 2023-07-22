using Database.Models;
using Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PersonasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PeopleController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPost]
        public async Task<ActionResult> PostPerson(Person person)
        {
            if (person == null)
                return BadRequest();

            await _personRepository.CreatePerson(person);
            return Created($"/api/people/{person.Id}", person);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePerson(int id, Person updatedPerson)
        {
            if (updatedPerson == null || id != updatedPerson.Id)
                return BadRequest();

            var existingPerson = await _personRepository.GetPersonById(id);
            if (existingPerson == null)
                return NotFound();

            existingPerson.Name = updatedPerson.Name;

            await _personRepository.UpdatePerson(existingPerson);

            return NoContent();
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> GetPeople()
        {
            return await _personRepository.GetPeople();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var person = await _personRepository.GetPersonById(id);

            if (person == null)
                return NotFound();

            return person;
        }

        [HttpGet("random")]
        public async Task<ActionResult<Person>> GetRandomPerson()
        {
            var randomPerson = await _personRepository.GetRandomPerson();

            if (randomPerson == null)
                return NotFound();

            return randomPerson;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonById(int id)
        {
            var person = await _personRepository.DeletePersonById(id);

            if (!person)
                return NotFound();

            return NoContent();
        }
    }
}
