using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Sizes;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class SizeTests
  {
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new Small() },
      new object[] { new Medium() },
      new object[] { new Large() }
    };

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Small()
    {
      var sut = new Small();

      Assert.True(sut.Name.Equals("Small"));
      Assert.True(sut.Price.Equals(5.00m));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Medium()
    {
      var sut = new Medium();

      Assert.True(sut.Name.Equals("Medium"));
      Assert.True(sut.Price.Equals(6.00m));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Large()
    {
      var sut = new Large();

      Assert.True(sut.Name.Equals("Large"));
      Assert.True(sut.Price.Equals(7.00m));
    }

    /// <summary>
    /// test tostring override
    /// </summary>
    /// <param name="Size"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_SizeName(ASize Size)
    {
      Assert.NotNull(Size.Name);
      Assert.Equal(Size.Name, Size.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="SizeName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("Small")]
    [InlineData("Medium")]
    [InlineData("Large")]
    public void Test_SizeNameSimple(string Name)
    {
      Assert.NotNull(Name);
    }
  }
}