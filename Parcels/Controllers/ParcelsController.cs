using Microsoft.AspNetCore.Mvc;
using ParcelSolution.Models;
using System.Collections.Generic;

namespace ParcelSolution.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcels> allParcels = Parcels.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/parcels")]
      public ActionResult Create(int length, int depth, int width, int weight)
      {
        Parcels newParcels = new Parcels(length, depth, width, weight);
        return RedirectToAction("Index", newParcels);
      }
    }

  }
