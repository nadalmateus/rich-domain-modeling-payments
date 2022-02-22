using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities;

[TestClass]
public class StudentTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var name = new Name("Mateus", "Nadal");
        foreach (var not in name.Notifications)
        {
            not.Message;
        }
    }
}
