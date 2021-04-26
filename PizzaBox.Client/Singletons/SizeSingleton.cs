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
  public class SizeSingleton
  {
    private const string _path = @"data/sizes.xml";
    private readonly FileRepository _fileRepository = new FileRepository();
    private readonly PizzaBoxContext _context = new PizzaBoxContext();
    private static SizeSingleton _instance;

    public List<ASize> Sizes { get; }
    public static SizeSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new SizeSingleton();
        }

        return _instance;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private SizeSingleton()
    {
      if (Sizes == null)
      {
        //Sizes = _context.Sizes.ToList();
        Sizes = _fileRepository.ReadFromFile<List<ASize>>(_path);
      }
    }
  }
}
