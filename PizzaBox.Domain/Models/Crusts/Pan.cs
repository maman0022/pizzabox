using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class Pan : ACrust
  {
    public Pan()
    {
      Name = "Pan";
      Price = 5.00m;
    }
  }
}