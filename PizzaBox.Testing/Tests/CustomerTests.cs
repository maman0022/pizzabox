using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class CustomerTests
  {
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new Customer("Test1") },
      new object[] { new Customer("Test2") }
    };
    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Customer()
    {
      var customer = new Customer("Test");

      Assert.True(customer.Name.Equals("Test"));
    }

    /// <summary>
    /// test tostring override
    /// </summary>
    /// <param name="Customer"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_CustomerName(Customer Customer)
    {
      Assert.NotNull(Customer.Name);
      Assert.Equal(Customer.Name, Customer.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="CustomerName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("Customer")]
    public void Test_CustomerNameSimple(string Name)
    {
      Assert.NotNull(Name);
    }
  }
}