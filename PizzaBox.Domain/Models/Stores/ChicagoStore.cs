using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Stores
{
  public class ChicagoStore : AStore
  {
    public ChicagoStore()
    {
      Name = "Chicago Store";
      Orders = new List<Order>();
    }
  }
}
