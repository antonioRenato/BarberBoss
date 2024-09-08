using BarberBoss.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BarberBoss.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterInvoiceJson request)
        {
            return Created();
        }
    }
}
