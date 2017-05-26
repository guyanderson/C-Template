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
      Get["/AddCD"] = _ => {
        List<Artist> allArtists = Artist.GetAll();
        return View["AddCD.cshtml", allArtists];
      };
      Get["/ViewArtists/{id}"] = parameters => {
        Dictionary<string, object> viewModel = new Dictionary<string, object>();
        Artist selectedArtist = Artist.Find(parameters.Id);
        List<CD> ArtistCD = selectedArtist.GetCDs();
        viewModel.Add("Artist", selectedArtist);
        viewModel.Add("CDs", ArtistCD);
        return View["artistDetailPage",viewModel];
      };
      Post["/AddCD/{id}"] = parameters => {
        Dictionary<string, object> viewModel = new Dictionary<string, object>();
        CD newCD = new CD(Request.Form["CD-name"]);
        Artist artist = Artist.Find(parameters.Id);
        artist.AddCD(newCD);
        List<CD> ArtistCD = artist.GetCDs();
        viewModel.Add("Artist", artist);
        viewModel.Add("CDs", ArtistCD);
        return View["artistDetailPage",viewModel];
      };
    }
  }
}
