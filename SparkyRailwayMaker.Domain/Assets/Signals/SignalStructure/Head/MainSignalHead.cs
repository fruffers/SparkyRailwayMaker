using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyRailwayMaker.Domain.Assets.Signals.SignalStructure
{
    public class MainSignalHead : SignalHead
    {
        public int AspectCount { get; set; }
        public int IsAutomatic { get; set; }
        public Aspect Aspect { get; set; }
    }
}
