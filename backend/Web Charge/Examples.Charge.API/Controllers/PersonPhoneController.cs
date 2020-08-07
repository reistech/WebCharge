using AutoMapper;
using Examples.Charge.API;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Microsoft.AspNetCore.Mvc;
using PersonPhones.Charge.Application.Interfaces;
using System.Threading.Tasks;

namespace PersonPhoneControllers.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PersonPhone personPhone)
        {
            return Response(0,await _facade.AddPersonPhoneAsync(personPhone));

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed(int id)
        {

        }
    }
}
