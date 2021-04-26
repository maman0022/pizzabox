using System.Xml;
using PizzaBox.Domain.Models.Crusts;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(Pan))]
  [XmlInclude(typeof(Stuffed))]
  [XmlInclude(typeof(Thin))]
  public class ACrust : AComponent
  {

  }
}
