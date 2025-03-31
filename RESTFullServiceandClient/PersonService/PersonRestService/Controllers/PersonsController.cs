using Microsoft.AspNetCore.Mvc;
using PersonRestService.BusinesslogicLayer;
using PersonRestService.DTOs;

namespace PersonRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonData _businessLogicCtrl;

        public PersonsController(IPersonData inBusinessLogicCtrl)
        {
            _businessLogicCtrl = inBusinessLogicCtrl;
        }

        // GET: api/persons
        [HttpGet]
        public ActionResult<List<PersonDTO>> Get()
        {
            var persons = _businessLogicCtrl.Get();
            if (persons == null)
                return StatusCode(500); // Internal server error
            if (persons.Count == 0)
                return NoContent(); // 204
            return Ok(persons); // 200
        }

        // GET: api/persons/3
        [HttpGet("{id}")]
        public ActionResult<PersonDTO> Get(int id)
        {
            var person = _businessLogicCtrl.Get(id);
            if (person == null)
                return NotFound(); // 404
            return Ok(person); // 200
        }

        // POST: api/persons
        [HttpPost]
        public ActionResult<int> PostNewPerson([FromBody] PersonDTO inPersonDto)
        {
            if (inPersonDto == null) return BadRequest();

            int insertedId = _businessLogicCtrl.Add(inPersonDto);
            if (insertedId > 0)
                return Ok(insertedId);
            if (insertedId == 0)
                return BadRequest(); // Missing input
            return StatusCode(500); // Error
        }
    }
}
