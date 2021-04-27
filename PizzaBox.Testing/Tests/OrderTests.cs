using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models.Pizzas;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class OrderTests
  {
    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_Order()
    {
      var order = new Order();
      order.Pizza = new MeatPizza();
      order.Store = new ChicagoStore();
      order.Customer = new Customer("Test");

      Assert.True(order.Pizza.Name.Equals("Meat Pizza"));
      Assert.True(order.Store.Name.Equals("Chicago Store"));
      Assert.True(order.Customer.Name.Equals("Test"));
    }
  }
}