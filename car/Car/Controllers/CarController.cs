using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public List<CarDto> cars = new List<CarDto>();
        [HttpGet("[action]")]
        public CarDto Get(int Id)//await -> async -> task<> -> нужна бд(ее нет)
        {
            return cars.FirstOrDefault(e => e.Id == Id);
        }
        [HttpPost("[action]")]
        public void Add(CarDto car)
        {
            cars.Add(car);
        }
    }
}
