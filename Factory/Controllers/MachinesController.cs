using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
  
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index(string searchString)
    {
      ViewBag.PageTitle = "All Machines";
      if (!String.IsNullOrEmpty(searchString))
      {
        List<Machine> model = _db.Machines
          .Where(machine => machine.Name.Contains(searchString))
          .OrderBy(machine => machine.Name)
          .ToList();
        return View(model);
      }
      else
      {
        List<Machine> model = _db.Machines
          .OrderBy(machine => machine.Name)
          .ToList();
        return View(model);
      }
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Assign Machine";
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine, int EngineerId)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      if (EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}