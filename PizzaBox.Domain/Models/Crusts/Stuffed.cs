using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class Stuffed : ACrust
  {
    public Stuffed()
    {
      Name = "Stuffed";
      Price = 6.00m;
    }
  }
}