using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpots> Get()
        {
            string topSpotsString = File.ReadAllText(@"C:\Dev\11-TopSpotsAPI\SD.JSON");

                TopSpots[] topSpots = JsonConvert.DeserializeObject<TopSpots[]>(topSpotsString);
            return topSpots;
        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
      
        }

        // POST: api/TopSpots
        public void Post(TopSpots topspots)
        {
            //return topspots;
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
