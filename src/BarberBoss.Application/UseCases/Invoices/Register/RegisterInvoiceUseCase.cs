using BarberBoss.Communication.Enums;
using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;
using BarberBoss.Exception.ExceptionsBase;
using FluentValidation;

namespace BarberBoss.Application.UseCases.Invoices.Register
{
    public class RegisterInvoiceUseCase
    {        
        public ResponseRegisterInvoiceJson Execute(RequestRegisterInvoiceJson request)
        {
            Validate(request);

            return new ResponseRegisterInvoiceJson();
        }

        public void Validate(RequestRegisterInvoiceJson request)
        {
            var validator = new RegisterInvoiceValidator();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();

                throw new ErrorBaseException(errorMessages);
            }
        }
    }
}
