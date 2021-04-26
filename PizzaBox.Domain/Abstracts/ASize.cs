using System.Xml.Serialization;
using PizzaBox.Domain.Models.Sizes;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(Small))]
  [XmlInclude(typeof(Medium))]
  [XmlInclude(typeof(Large))]
  public class ASize : AComponent
  {

  }
}
