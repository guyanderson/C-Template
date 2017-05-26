using Nancy;
using System.Collections.Generic;
using Organizer.Objects;

namespace Organizer.Modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/AddArtist"] = _ => {
        return View["AddArtist.cshtml"];
      };
      Post["/AddArtist"] = _ => {
        Artist newArtist = new Artist(Request.Form["artist-name"]);
        List<Artist> allArtists = Artist.GetAll();
        return View["ViewArtists.cshtml", allArtists];
      };
    }
  }
}
