using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models.Pizzas
{
  [XmlInclude(typeof(Mushrooms))]
  [XmlInclude(typeof(Onions))]
  public class VeggiePizza : APizza
  {
    public VeggiePizza()
    {

    }
  }
}
