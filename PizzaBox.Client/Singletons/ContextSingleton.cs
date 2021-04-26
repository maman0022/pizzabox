using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing.Repositories;
using System.Linq;
using PizzaBox.Storing;

namespace PizzaBox.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class ContextSingleton
  {
    private static PizzaBoxContext _instance;

    public static PizzaBoxContext Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new PizzaBoxContext();
        }
        return _instance;
      }
    }
  }
}
