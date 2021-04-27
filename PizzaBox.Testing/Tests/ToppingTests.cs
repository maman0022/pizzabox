using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class ToppingTests
  {
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new Mushrooms() },
      new object[] { new Onions() },
      new object[] { new Pepperoni() },
      new object[] { new Sausage() }
    };

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Mushrooms()
    {
      var sut = new Mushrooms();

      Assert.True(sut.Name.Equals("Mushrooms"));
      Assert.True(sut.Price.Equals(2.00m));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Onions()
    {
      var sut = new Onions();

      Assert.True(sut.Name.Equals("Onions"));
      Assert.True(sut.Price.Equals(2.00m));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Pepperoni()
    {
      var sut = new Pepperoni();

      Assert.True(sut.Name.Equals("Pepperoni"));
      Assert.True(sut.Price.Equals(3.00m));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Sausage()
    {
      var sut = new Sausage();

      Assert.True(sut.Name.Equals("Sausage"));
      Assert.True(sut.Price.Equals(3.00m));
    }

    /// <summary>
    /// test tostring override
    /// </summary>
    /// <param name="Topping"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_ToppingName(ATopping Topping)
    {
      Assert.NotNull(Topping.Name);
      Assert.Equal(Topping.Name, Topping.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ToppingName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("Mushrooms")]
    [InlineData("Onions")]
    [InlineData("Pepperoni")]
    [InlineData("Sausage")]
    public void Test_ToppingNameSimple(string Name)
    {
      Assert.NotNull(Name);
    }
  }
}