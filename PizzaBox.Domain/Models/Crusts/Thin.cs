using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Crusts
{
  public class Thin : ACrust
  {
    public Thin()
    {
      Name = "Thin";
      Price = 4.00m;
    }
  }
}