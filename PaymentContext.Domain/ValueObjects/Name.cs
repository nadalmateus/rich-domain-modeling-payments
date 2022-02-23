using System.ComponentModel.DataAnnotations;
using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;


    }

    [Required]
    public string FirstName { get; }
    public string LastName { get; }
}
