using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoCoreApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CargoCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
       private readonly CargoDbContext cargodbcontext;
        public CargoController(CargoDbContext cargoDbContext)
        {
            cargodbcontext = cargoDbContext;
        }
        [HttpGet]
        public IEnumerable<CargoSystem> GetCargoSystems()
        {
            return cargodbcontext.cargoSystem.ToList();
        }
        [HttpGet("GetCustomerId")]
        public CargoSystem GetCustomerId(int Customer_Id)
        {
            return cargodbcontext.cargoSystem.Find(Customer_Id);
        }
        [HttpPost("InsertCargo")]
        public IActionResult InsertCargo([FromBody] CargoSystem cargoSystem)
        {
            if (cargoSystem.Customer_Id.ToString() != "")
            {
                cargodbcontext.cargoSystem.Add(cargoSystem);
                cargodbcontext.SaveChanges();
                return Ok("Cargo Details saved successfully!");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("UpdateCargo")]
        public IActionResult UpdateCargo([FromBody] CargoSystem cargoSystem)
        {
            if (cargoSystem.Customer_Id.ToString() != "")
            {
                cargodbcontext.Entry(cargoSystem).State = EntityState.Modified;
                cargodbcontext.SaveChanges();
                return Ok("Cargo Details updated successfully!");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("DeleteCargo")]
        public IActionResult DeleteCargo(int Customer_Id)
        {
            var result = cargodbcontext.cargoSystem.Find(Customer_Id);
            cargodbcontext.cargoSystem.Remove(result);
            cargodbcontext.SaveChanges();
            return Ok("Deleted Successfully");

        }
    }
}
