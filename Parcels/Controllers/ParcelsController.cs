using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string description, int weight, int length, int height, int width)
    {
      Parcel myParcel = new Parcel(description, weight, length, height, width);
      Parcel.CalculatePrice(myParcel);
      return RedirectToAction("Index");
    }

  }
}
