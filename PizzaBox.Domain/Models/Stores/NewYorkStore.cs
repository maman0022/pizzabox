using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Stores
{
  public class NewYorkStore : AStore
  {
    public NewYorkStore()
    {
      Name = "New York Store";
      Orders = new List<Order>();
    }
  }
}
