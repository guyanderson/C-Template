using Nancy;
using System.Collections.Generic;
// using Organizer.Objects;

namespace Organizer.Modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
    }
  }
}
