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
  public class StoreSingleton
  {
    private const string _path = @"data/stores.xml";
    private readonly FileRepository _fileRepository = new FileRepository();
    private readonly PizzaBoxContext _context = new PizzaBoxContext();
    private static StoreSingleton _instance;

    public List<AStore> Stores { get; }
    public static StoreSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new StoreSingleton();
        }

        return _instance;
      }
    }
    public void SaveToXml(List<AStore> list)
    {
      _fileRepository.WriteToFile<List<AStore>>(_path, list);
    }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
      if (Stores == null)
      {
        //Stores = _context.Stores.ToList();
        Stores = _fileRepository.ReadFromFile<List<AStore>>(_path);
      }
    }
  }
}
