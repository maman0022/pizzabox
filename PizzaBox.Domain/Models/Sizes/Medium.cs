using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Sizes
{
  public class Medium : ASize
  {
    public Medium()
    {
      Name = "Medium";
      Price = 6.00m;
    }
  }
}