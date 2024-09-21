using BarberBoss.Communication.Requests;
using FluentValidation;

namespace BarberBoss.Application.UseCases.Invoices.Register
{
    public class RegisterInvoiceValidator : AbstractValidator<RequestRegisterInvoiceJson>
    {
        public RegisterInvoiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("The title is required!");
            RuleFor(x => x.Amount).GreaterThan(0).WithMessage("The amount must be greater than zero");
            RuleFor(x => x.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("The date is in the future");
            RuleFor(x => x.PaymentType).IsInEnum().WithMessage("Payment type is not valid");
        }
    }
}
