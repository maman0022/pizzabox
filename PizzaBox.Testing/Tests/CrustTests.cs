using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Crusts;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class CrustTests
  {
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new Thin() },
      new object[] { new Pan() },
      new object[] { new Stuffed() }
    };

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Thin()
    {
      var sut = new Thin();

      Assert.True(sut.Name.Equals("Thin"));
      Assert.True(sut.Price.Equals(4.00m));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Pan()
    {
      var sut = new Pan();

      Assert.True(sut.Name.Equals("Pan"));
      Assert.True(sut.Price.Equals(5.00m));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Stuffed()
    {
      var sut = new Stuffed();

      Assert.True(sut.Name.Equals("Stuffed"));
      Assert.True(sut.Price.Equals(6.00m));
    }

    /// <summary>
    /// test tostring override
    /// </summary>
    /// <param name="crust"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_crustName(ACrust crust)
    {
      Assert.NotNull(crust.Name);
      Assert.Equal(crust.Name, crust.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="CrustName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("Thin")]
    [InlineData("Pan")]
    [InlineData("Stuffed")]
    public void Test_CrustNameSimple(string Name)
    {
      Assert.NotNull(Name);
    }
  }
}