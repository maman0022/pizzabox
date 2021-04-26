using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sizes
{
  public class Large : ASize
  {
    public Large()
    {
      Name = "Large";
      Price = 7.00m;
    }
  }
}