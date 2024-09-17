﻿using BarberBoss.Communication.Enums;
using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;

namespace BarberBoss.Application.UseCases.Invoices.Register
{
    public class RegisterInvoiceUseCase
    {        
        public ResponseRegisterInvoiceJson Execute(RequestRegisterInvoiceJson request)
        {
            Validate(request);

            return new ResponseRegisterInvoiceJson();
        }

        private void Validate(RequestRegisterInvoiceJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Title))
                throw new ArgumentException("The title is required!");

            if (request.Amount <= 0)
                throw new ArgumentException("The amount must be greater than zero");

            var result = DateTime.Compare(request.Date, DateTime.UtcNow);
            if (result > 0)
                throw new ArgumentException("The date is in the future");

            var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
            if (!paymentTypeIsValid)
                throw new ArgumentException("Payment type is not valid");
        }
    }
}
