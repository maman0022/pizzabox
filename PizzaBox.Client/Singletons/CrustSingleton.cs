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
  public class CrustSingleton
  {
    private const string _path = @"data/crusts.xml";
    private readonly FileRepository _fileRepository = new FileRepository();
    private readonly PizzaBoxContext _context = new PizzaBoxContext();
    private static CrustSingleton _instance;

    public List<ACrust> Crusts { get; }
    public static CrustSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new CrustSingleton();
        }

        return _instance;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private CrustSingleton()
    {
      if (Crusts == null)
      {
        //Crusts = _context.Crusts.ToList();
        Crusts = _fileRepository.ReadFromFile<List<ACrust>>(_path);
      }
    }
  }
}
