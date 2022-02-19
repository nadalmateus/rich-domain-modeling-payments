using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var subscription = new Subscription(null);
        var student = new Student("Mateus", "Nadal", "123123123", "test@test.com");
        student.AddSubscription(subscription);
    }
}