using System.Collections;
using System.Collections.Generic;
using AspNetCoreSpike.Config;
using AspNetCoreSpike.Models;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.OptionsModel;

namespace AspNetCoreSpike.Data
{
    public class CarCollectionData : ICarCollectionData
    {
        private IHostingEnvironment _env;
        private ConfigSettings _config;

        public CarCollectionData(IHostingEnvironment env, IOptions<ConfigSettings> config)
        {
            _env = env;
            _config = config.Value;
        }

        public IEnumerable<Car> GetCars()
        {
            var astonDb9 = new Car
            {
                Drivetrain = "RWD",
                Engine = "V12",
                Make = "Aston Martin",
                Model = "DB9",
                Vin = _env.IsEnvironment("Dev") ? "1lkjsdflkj23498usflkjsdf" : _config.privateProdMessage,
                Year = "2014"
            };
            var jagXkr = new Car
            {
                Drivetrain = "RWD",
                Engine = "V8",
                Make = "Jaguar",
                Model = "XK-R",
                Vin = _env.IsEnvironment("Dev") ? "alkjsdflkjsdf98734oj" : _config.privateProdMessage,
                Year = "2012"
            };
            var fordGt = new Car
            {
                Drivetrain = "RWD",
                Engine = "V8",
                Make = "Ford",
                Model = "GT",
                Vin = _env.IsEnvironment("Dev") ? "lkj23987foiu2978efuj" : _config.privateProdMessage,
                Year = "2008"
            };
            var ferrari458 = new Car
            {
                Drivetrain = "RWD",
                Engine = "V8",
                Make = "Ferrari",
                Model = "458",
                Vin = _env.IsEnvironment("Dev") ? "jdfjw9872f8hdflj2i34" : _config.privateProdMessage,
                Year = "2009"
            };
            return new List<Car>
            {
                astonDb9,
                jagXkr,
                ferrari458,
                fordGt
            };
        }
    }

    public interface ICarCollectionData
    {
        IEnumerable<Car> GetCars();
    }
}