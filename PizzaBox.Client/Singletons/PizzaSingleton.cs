using System.Collections.Generic;
using System.Linq;
using PizzaBox.Storing;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class PizzaSingleton
  {
    private readonly FileRepository _fileRepository = new FileRepository();
    private static PizzaSingleton _instance;
    private const string _path = @"data/pizzas.xml";
    private static readonly PizzaBoxContext _contextSingleton = ContextSingleton.Instance;


    public List<APizza> Pizzas { get; set; }
    public static PizzaSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new PizzaSingleton();
        }

        return _instance;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private PizzaSingleton()
    {
      //Pizzas = _contextSingleton.Pizzas.ToList();
      Pizzas = _fileRepository.ReadFromFile<List<APizza>>(_path);
    }
  }
}
