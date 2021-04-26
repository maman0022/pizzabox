using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class Sausage : ATopping
  {
    public Sausage()
    {
      Name = "Sausage";
      Price = 3.00m;
    }
  }
}