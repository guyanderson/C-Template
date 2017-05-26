using System.Collections.Generic;
// using Organizer.CDs;

namespace Organizer.Objects
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    // private List<CDs> _CDs;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      // _CDs = new List<CDs>{};
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
  }
}
