using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using SixPillars.Web.Interfaces;

namespace SixPillars.Web.Controllers
{
    public class SixPillarsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Pillar> Get()
        {
            ISixPillarsModel myModel =new Models.SixPillarsModel();
            return myModel.Pillars;
        }
    }
}