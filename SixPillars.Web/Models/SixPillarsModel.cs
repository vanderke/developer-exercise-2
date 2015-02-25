using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SixPillars.Web.Models
{
    public class SixPillarsModel
    {
        public List<Pillar> SixPillars { get; private set; }
        public SixPillarsModel()
        {
            string JSONResult = string.Empty;
            string appdatafolder = System.IO.Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data");
            using (var DataSourceReader = new System.IO.StreamReader(new System.IO.FileStream(appdatafolder + "\\pillars.json", System.IO.FileMode.Open)))
            {
                JSONResult = DataSourceReader.ReadToEnd();
            }
            var result = System.Web.Helpers.Json.Decode(JSONResult);
            SixPillars = new List<Pillar>();
            foreach (dynamic myPillar in result)
            {
                SixPillars.Add(new Pillar(myPillar));
            }
        }
    }
}