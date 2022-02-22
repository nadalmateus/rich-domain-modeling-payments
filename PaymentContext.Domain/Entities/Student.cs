using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public class Student : Entity
{
    private readonly IList<Subscription> _subscriptions;

    public Student(Name name, Email email)
    {
        Name = name;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public Name Name { get; set; }
    public Document Document { get; }
    public Email Email { get; }
    public Address Address { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();


    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions) sub.Inactivate();

        _subscriptions.Add(subscription);
    }
}
