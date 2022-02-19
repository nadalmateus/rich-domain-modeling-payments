namespace PaymentContext.Domain.Entities;

public class Student
{
    private IList<Subscription> _subscriptions;
    public Student(string firstName, string lastName, string docummnet, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Docummnet = docummnet;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Docummnet { get; private set; }
    public string Email { get; private set; }
    public string Adress { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }


    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions)
        {
            sub.Inactivate();
        }

        _subscriptions.Add(subscription);
    }
}
