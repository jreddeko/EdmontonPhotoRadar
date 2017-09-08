using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoRadarMap.Models.EnforcementZones
{
    public class EnforcementZoneModel
    {
        public int sid { get; set; }
        public string id { get; set; }
        public int position { get; set; }
        public int created_at { get; set; }
        public string created_meta { get; set; }
        public int updated_at { get; set; }
        public string updated_meta { get; set; }
        public string meta { get; set; }
        public string site_id { get; set; }
        public string road_name { get; set; }
        public string location_description { get; set; }
        public string direction { get; set; }
        public string from_point { get; set; }
        public string to_point { get; set; }
        public string speed_limit { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public object[] geo_location { get; set; }
        public EnforcementZoneModel() { }
    }
}