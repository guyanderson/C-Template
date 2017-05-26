using System.Collections.Generic;

namespace Organizer.Objects
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<CD> _CDs;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _CDs = new List<CD>{};
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Artist>GetAll()
    {
      return _instances;
    }
    public List<CD> GetCDs()
    {
      return _CDs;
    }
    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
