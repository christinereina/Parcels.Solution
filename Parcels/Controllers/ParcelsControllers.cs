using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpPost("/parcel")]
    public ActionResult Index(int length, int width, int height, int weight)
    {
      Parcel newParcel = new Parcel(length, width, height, weight);
      return View(newParcel);
    }
  }
}