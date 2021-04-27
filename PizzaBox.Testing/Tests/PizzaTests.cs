using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class PizzaTests
  {
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new CustomPizza() },
      new object[] { new MeatPizza() },
      new object[] { new VeggiePizza() }
    };

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_CustomPizza()
    {
      var sut = new CustomPizza();

      Assert.True(sut.Name.Equals("Custom Pizza"));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_MeatPizza()
    {
      var sut = new MeatPizza();

      Assert.True(sut.Name.Equals("Meat Pizza"));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_VeggiePizza()
    {
      var sut = new VeggiePizza();

      Assert.True(sut.Name.Equals("Veggie Pizza"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="PizzaName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("CustomPizza")]
    [InlineData("MeatPizza")]
    [InlineData("VeggiePizza")]
    public void Test_PizzaNameSimple(string Name)
    {
      Assert.NotNull(Name);
    }
  }
}