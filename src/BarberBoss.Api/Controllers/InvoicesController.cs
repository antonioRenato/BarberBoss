using BarberBoss.Application.UseCases.Invoices.Register;
using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;
using BarberBoss.Exception.ExceptionsBase;
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
            try
            {
                var useCase = new RegisterInvoiceUseCase();
                var response = useCase.Execute(request);

                return Created(string.Empty, response);
            }
            catch (ErrorBaseException ex)
            {
                var errorResponse = new ResponseErrorJson(ex.Errors);
                
                return BadRequest(errorResponse);
            }
            catch
            {
                var errorResponse = new ResponseErrorJson("unkown error");

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
            
        }
    }
}
