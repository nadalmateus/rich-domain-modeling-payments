namespace PaymentContext.Domain.Entities;

public abstract class Payment
{
    protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string document,
        string payer, string adress, string email)
    {
        Number = Guid.NewGuid().ToString().Replace("_", "").Substring(0, 10).ToUpper();
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Document = document;
        Payer = payer;
        Adress = adress;
        Email = email;
    }

    public string Number { get; }
    public DateTime PaidDate { get; }
    public DateTime ExpireDate { get; }
    public decimal Total { get; }
    public decimal TotalPaid { get; }
    public string Document { get; }
    public string Payer { get; }
    public string Adress { get; }
    public string Email { get; }
}
