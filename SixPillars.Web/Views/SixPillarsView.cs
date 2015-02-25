using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SixPillars.Web.Interfaces;

namespace SixPillars.Web.Views
{
    public class SixPillarsView
    {
        ISixPillarsModel _model;
        public SixPillarsView(ISixPillarsModel model)
        {
            _model = model;
        }
        public List<Pillar> Pillars 
        {
            get
            {
                return _model.Pillars;
            }
        }
    }
}