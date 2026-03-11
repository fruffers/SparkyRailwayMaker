using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyRailwayMaker.Domain.Assets.Signals.SignalStructure.Head
{
    public abstract class SignalHead : SignalComponent
    {
        public SignalDirection Direction { get; set; }
    }
}
