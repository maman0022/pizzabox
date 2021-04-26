using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sizes
{
  public class Small : ASize
  {
    public Small()
    {
      Name = "Small";
      Price = 5.00m;
    }
  }
}