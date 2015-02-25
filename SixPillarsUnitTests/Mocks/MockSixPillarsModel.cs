using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPillarsUnitTests.Mocks
{
    class MockSixPillarsModel : SixPillars.Web.Interfaces.ISixPillarsModel
    {
        List<SixPillars.Web.Pillar> _pillars = new List<SixPillars.Web.Pillar>();

        public List<SixPillars.Web.Pillar> Pillars
        {
            get
            {
                return _pillars;
            }
        }
    }
}
