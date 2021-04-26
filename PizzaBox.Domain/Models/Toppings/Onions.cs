using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Onions : ATopping
  {
    public Onions()
    {
      Name = "Onions";
      Price = 2.00m;
    }
  }
}