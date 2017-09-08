using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PhotoRadarMap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var s = new Models.EnforcementZones.Factories.EnforcementZonesSerializer();
            var model1 = s.PrepareEnforcementZoneModel("http://data.edmonton.ca/api/views/4cqz-cd52/rows.json?accessType=DOWNLOAD");
            var model2 = s.PrepareEnforcementZoneModel("http://data.edmonton.ca/api/views/fwx6-by2r/rows.json?accessType=DOWNLOAD");
            return View(model1.Union(model2).ToList());
        }
    }
}
