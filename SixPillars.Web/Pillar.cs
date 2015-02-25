using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SixPillars.Web
{
    public class Pillar
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Scripture { get; set; }

        public Pillar(dynamic JSONObject = null)
        {
            if (JSONObject != null)
            {
                Title = JSONObject.title;
                Description = JSONObject.description;
                Scripture = JSONObject.scripture;
            }
        }
    }
}