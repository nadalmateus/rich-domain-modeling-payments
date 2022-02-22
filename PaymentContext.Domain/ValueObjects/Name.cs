using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        if (string.IsNullOrEmpty(FirstName))
            AddNotification("Name.FirstName", "Nome Invalido");
    }

    public string FirstName { get; }
    public string LastName { get; }
}
