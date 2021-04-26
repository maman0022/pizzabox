using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Mushrooms : ATopping
  {
    public Mushrooms()
    {
      Name = "Mushrooms";
      Price = 2.00m;
    }
  }
}