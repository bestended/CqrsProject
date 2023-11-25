using CqrsProject.Cqrs.Commands;
using CqrsProject.Cqrs.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CqrsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalsController : Controller
    {
        private readonly IMediator _meadiator;

        public PersonalsController(IMediator meadiator)
        {
            _meadiator = meadiator;
        }

        [HttpGet]
        public async Task<IActionResult>  GetAll()
        {
            var result = await _meadiator.Send(new GetPersonalsQuery());
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonal(int id)
        {

            var result = await _meadiator.Send(new GetPersonalsByIdQuery(id));
            return Ok(result);


        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePersonalsCommand command)
        {
            await _meadiator.Send(command);
            return Created("",command.Name);
                


        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _meadiator.Send(new RemovePersonalsCommand(id));
            return NoContent();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdatePersonalsCommand command)
        {

            await _meadiator.Send(command);
            return NoContent();

        }



    }
}
