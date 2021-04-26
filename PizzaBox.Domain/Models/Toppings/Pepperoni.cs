using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Pepperoni : ATopping
  {
    public Pepperoni()
    {
      Name = "Pepperoni";
      Price = 3.00m;
    }
  }
}