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
  public class ToppingSingleton
  {
    private const string _path = @"data/toppings.xml";
    private readonly FileRepository _fileRepository = new FileRepository();
    private static readonly PizzaBoxContext _contextSingleton = ContextSingleton.Instance;
    private static ToppingSingleton _instance;

    public List<ATopping> Toppings { get; }
    public static ToppingSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new ToppingSingleton();
        }

        return _instance;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private ToppingSingleton()
    {
      if (Toppings == null)
      {
        //Toppings = _contextSingleton.Toppings.ToList();
        Toppings = _fileRepository.ReadFromFile<List<ATopping>>(_path);
      }
    }
  }
}
