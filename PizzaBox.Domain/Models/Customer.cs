using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Customer : AModel
  {

    public string Name { get; }
    public Customer(string name)
    {
      Name = name;
    }

    public Customer()
    {

    }

    public override string ToString()
    {
      return Name;
    }
  }
}