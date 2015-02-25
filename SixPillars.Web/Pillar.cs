using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SixPillars.Web
{
    public class Pillar
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Scripture { get; private set; }

        public Pillar(dynamic JSONObject)
        {
            Title = JSONObject.title;
            Description = JSONObject.description;
            Scripture = JSONObject.scripture;
        }
    }
}