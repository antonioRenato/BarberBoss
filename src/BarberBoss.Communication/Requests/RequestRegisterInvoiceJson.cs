﻿using BarberBoss.Communication.Enums;

namespace BarberBoss.Communication.Requests
{
    public class RequestRegisterInvoiceJson
    {
        public string Title { get; set; } = string.Empty;
        public string NameBarber {  get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
