using BarberBoss.Application.UseCases.Invoices.Register;
using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;
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
            catch (ArgumentException ex)
            {
                var errorResponse = new ResponseErrorJson
                { 
                    ErrorMessage = ex.Message 
                };
                
                return BadRequest(errorResponse);
            }
            catch
            {
                var errorResponse = new ResponseErrorJson
                {
                    ErrorMessage = "unkown error"
                };

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
            
        }
    }
}
