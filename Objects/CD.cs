using System.Collections.Generic;

namespace Organizer.Objects
{
  public class CD
  {
    private string _name;
    private int _id;
    private static List<CD> _instances = new List<CD> {};

    public CD (string CDName)
    {
      _name = CDName;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<CD>GetAll()
    {
      return _instances;
    }
  }
}
