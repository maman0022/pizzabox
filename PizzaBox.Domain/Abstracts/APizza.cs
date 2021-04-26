using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Domain.Abstracts
{
  [XmlInclude(typeof(CustomPizza))]
  [XmlInclude(typeof(MeatPizza))]
  [XmlInclude(typeof(VeggiePizza))]
  public abstract class APizza : AModel
  {
    public ACrust Crust { get; set; }
    public ASize Size { get; set; }
    public List<ATopping> Toppings { get; set; }
    public string Name { get; set; }
    public APizza()
    {
      Toppings = new List<ATopping>();
    }

    public decimal CalculateTotal()
    {
      decimal totalPrice = 0.0m;
      foreach (var topping in Toppings)
      {
        totalPrice += topping.Price;
      }
      totalPrice += Crust.Price;
      totalPrice += Size.Price;
      return totalPrice;
    }
  }
}
