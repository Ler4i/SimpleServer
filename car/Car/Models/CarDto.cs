using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car
{
    public class CarDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Co2 { get; set; }
        public string FuelCons { get; set; }
    }
}
