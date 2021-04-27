using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models.Pizzas
{
  [XmlInclude(typeof(Pepperoni))]
  [XmlInclude(typeof(Sausage))]

  public class MeatPizza : APizza
  {
    public MeatPizza()
    {
      Name = "Meat Pizza";
      Toppings.Add(new Pepperoni());
      Toppings.Add(new Sausage());
    }
  }
}
