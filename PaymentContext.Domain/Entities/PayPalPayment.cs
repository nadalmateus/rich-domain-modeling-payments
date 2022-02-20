namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(
        string transactionCode,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string document,
        string payer,
        string adress,
        string email) : base(paidDate, expireDate, total, totalPaid, document, payer, adress, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; }
}
