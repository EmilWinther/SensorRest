using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorDataLib;

namespace SensorRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SensorDataController : ControllerBase
    {
        private static DateTime dt = DateTime.Now;
        private static readonly List<SensorData> _data = new List<SensorData>
        {
            new SensorData("yeeeeeeeah", 80, dt.ToLongTimeString())
        };
        [HttpGet]
        public List<SensorData> GetAllSensorData()
        {
            return new List<SensorData>(_data);
        }
        [HttpPost]
        public SensorData Add(SensorData newData)
        {
            _data.Add(newData);
            DateTime dt2 = DateTime.Now;
            newData.TimeStamp = dt2.ToLongTimeString();
            return newData;
        }
    }
}
