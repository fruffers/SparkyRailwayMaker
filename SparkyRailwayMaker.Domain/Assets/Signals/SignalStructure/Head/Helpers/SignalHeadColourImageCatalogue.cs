using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyRailwayMaker.Domain.Assets.Signals.SignalStructure
{
    public static class SignalHeadColourImageCatalogue
    {
        public static readonly IReadOnlyDictionary<Aspect, LampImageSet> Images
            = new Dictionary<Aspect, LampImageSet>
            {
                [Aspect.Green] = new LampImageSet
                {
                    LitImagePath = "Assets/Signals/SignalHeadColourImages/GreenLit.png",
                    UnlitImagePath = "Assets/Signals/SignalHeadColourImages/GreenUnlit.png"
                },
                [Aspect.Yellow] = new LampImageSet
                {
                    LitImagePath = "Assets/Signals/SignalHeadColourImages/YellowLit.png",
                    UnlitImagePath = "Assets/Signals/SignalHeadColourImages/YellowUnlit.png"
                },
                [Aspect.Red] = new LampImageSet
                {
                    LitImagePath = "Assets/Signals/SignalHeadColourImages/RedLit.png",
                    UnlitImagePath = "Assets/Signals/SignalHeadColourImages/RedUnlit.png"
                },
                 [Aspect.DoubleYellow] = new LampImageSet
                 {
                     LitImagePath = "Assets/Signals/SignalHeadColourImages/DoubleYellowLit.png",
                     UnlitImagePath = "Assets/Signals/SignalHeadColourImages/DoubleYellowUnlit.png"
                 }
            };
    }
}
