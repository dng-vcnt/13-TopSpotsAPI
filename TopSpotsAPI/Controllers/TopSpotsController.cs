using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: TopSpots
        public IEnumerable<TopSpots> Get()
        {
            // Read file into string and deserialize JSON to a type
            TopSpots[] topSpot = JsonConvert.DeserializeObject<TopSpots[]>(File.ReadAllText(@"z:\dev\05-SanDiegoTopSpots-Angular\topspots.json"));

            return topSpot;

        }

    }
}