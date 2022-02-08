using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TutorialAppCore.Models;

namespace TutorialAppCore.Controllers
{
    public class CargoController : Controller
    {
        CargoDbContext cargoDbContext;
        public CargoController(CargoDbContext cargodbcontext)
        {
            cargoDbContext = cargodbcontext;
        }
        public IActionResult Index()
        {
            var cargoInfo = cargoDbContext.cargosystem.ToList();  //select * from CargoSystem
            return View(cargoInfo);
        }
        public IActionResult InsertCargo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertCargo(CargoSystem cargosystem)
        {
            cargoDbContext.cargosystem.Add(cargosystem); //insert into CargoSystem...
            cargoDbContext.SaveChanges();
            ViewBag.message = "Cargo details saved successfully!..";
            return View();
        }
        public IActionResult UpdateCargo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateCargo(CargoSystem cargosystem)
        {
            cargoDbContext.Entry(cargosystem).State = EntityState.Modified;
            cargoDbContext.SaveChanges();
            ViewBag.message = "Cargo Details Updated successfully!..";
            return View();
        }

        public IActionResult DeleteCargo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCargo(int Customer_Id)
        {
            var result = cargoDbContext.cargosystem.Find(Customer_Id);
            cargoDbContext.cargosystem.Remove(result);
            cargoDbContext.SaveChanges();
            ViewBag.message = "Cargo details deleted successfully!..";
            return View();

        }
    }
}
