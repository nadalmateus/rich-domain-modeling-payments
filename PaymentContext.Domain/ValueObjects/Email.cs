using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects;

public class Email : ValueObject
{
    public Email(string address)
    {
        Address = address;

        AddNotifications(new Contract<string>().Requires().IsEmail(Address, "Email.Address", "Email Invalido"));
    }

    public string Address { get; set; }
}
