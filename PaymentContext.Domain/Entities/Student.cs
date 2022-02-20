namespace PaymentContext.Domain.Entities;

public class Student
{
    private readonly IList<Subscription> _subscriptions;

    public Student(string firstName, string lastName, string docummnet, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Docummnet = docummnet;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Docummnet { get; }
    public string Email { get; }
    public string Adress { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();


    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions) sub.Inactivate();

        _subscriptions.Add(subscription);
    }
}
