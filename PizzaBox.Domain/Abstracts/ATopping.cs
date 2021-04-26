using System.Xml.Serialization;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Abstracts
{
  [XmlInclude(typeof(Sausage))]
  [XmlInclude(typeof(Pepperoni))]
  [XmlInclude(typeof(Mushrooms))]
  [XmlInclude(typeof(Onions))]
  public class ATopping : AComponent
  {
    public override string ToString()
    {
      return Name;
    }
  }
}
