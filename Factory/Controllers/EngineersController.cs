using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index(string searchString)
    {
      ViewBag.PageTitle = "View All Courses";
      if (!String.IsNullOrEmpty(searchString))
      {
        List<Engineer> model = _db.Engineers
          .Where(Engineer => Engineer.Name.Contains(searchString))
          .OrderBy(Engineer => Engineer.Name)
          .ToList();
        return View(model);
      }
      else
      {
        List<Engineer> model = _db.Engineers
          .OrderBy(Engineer => Engineer.Name)
          .ToList();
        return View(model);
      }
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "New Engineer";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisEngineer = _db.Engineers
        .Include(engineer => engineer.JoinEntities)
        .ThenInclude(join =>join.Machine)
        .FirstOrDefault(engineer => engineer.EngineerId == id);
      ViewBag.PageTitle = "Details";
      return View(thisEngineer);
    }
  }
}