using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaos
{
    public class Tagtider
    {
        public string id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string slug { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Stations
    {
        public List<Tagtider> station { get; set; }
    }

    public class RootObject
    {
        public Stations stations { get; set; }
    }
}