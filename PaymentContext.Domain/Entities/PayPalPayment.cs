using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(
        string transactionCode,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        Document document,
        string payer,
        Address Address,
        Email email) : base(paidDate, expireDate, total, totalPaid, document, payer, Address, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; }
}
