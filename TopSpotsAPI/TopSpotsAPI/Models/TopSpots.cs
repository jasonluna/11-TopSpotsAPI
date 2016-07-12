using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopSpotsAPI.Models;
namespace TopSpotsAPI.Models
{
    public class TopSpots
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal[] Location { get; set; }
    }
}
