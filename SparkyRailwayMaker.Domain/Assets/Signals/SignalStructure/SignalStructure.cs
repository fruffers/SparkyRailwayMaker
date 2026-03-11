using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyRailwayMaker.Domain.Assets.Signals.SignalStructure
{
    public class SignalStructure : RailwayAsset
    {
        public string? Name { get; set; }

        public SignalStructureType StructureType { get; set; }

        public List<SignalComponent> Components { get; set; } = new List<SignalComponent>();
    }
}
