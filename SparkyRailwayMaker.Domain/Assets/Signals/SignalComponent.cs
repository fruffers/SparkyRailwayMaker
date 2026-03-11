using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyRailwayMaker.Domain.Assets.Signals
{
    public abstract class SignalComponent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int MountOrder {  get; set; }

        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
    }
}
