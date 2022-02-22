using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public abstract class Payment
{
    public Payment(
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        Document document,
        string payer,
        Address address,
        Email email)
    {
        Number = Guid.NewGuid().ToString().Replace("_", "").Substring(0, 10).ToUpper();
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Document = document;
        Payer = payer;
        Address = address;
        Email = email;
    }

    public string Number { get; }
    public DateTime PaidDate { get; }
    public DateTime ExpireDate { get; }
    public decimal Total { get; }
    public decimal TotalPaid { get; }
    public Document Document { get; }
    public string Payer { get; }
    public Address Address { get; }
    public Email Email { get; }
}
