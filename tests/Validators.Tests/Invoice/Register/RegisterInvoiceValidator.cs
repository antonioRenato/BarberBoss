using BarberBoss.Application.UseCases.Invoices.Register;
using BarberBoss.Communication.Requests;

namespace Validators.Tests.Invoice.Register
{
    public class RegisterInvoiceValidator
    {
        [Fact]
        public void Sucess()
        {
            var validator = new RegisterInvoiceUseCase();
            var request = new RequestRegisterInvoiceJson
            {
                Title = "Corte",
                Date = DateTime.Now,
                Amount = 30,
                NameBarber = "Antonio",
                PaymentType = BarberBoss.Communication.Enums.PaymentType.DebitCard,
            };

            var result = validator.Validate(request);
        }
    }
}
