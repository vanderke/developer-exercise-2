using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPillars.Web.Interfaces
{
    public interface ISixPillarsModel
    {
        List<Pillar> Pillars { get; }
    }
}
