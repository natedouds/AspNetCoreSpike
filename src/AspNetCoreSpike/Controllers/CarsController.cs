using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AspNetCoreSpike.Data;
using AspNetCoreSpike.Models;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc;

namespace AspNetCoreSpike.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private ICarCollectionData _carData;

        public CarsController(ICarCollectionData carData)
        {
            _carData = carData;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            Console.WriteLine("Running in environment{}");

            return _carData.GetCars();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}