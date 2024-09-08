using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    internal interface IShadowable
    {
        bool Shadow { get; set; }
        string ShadowColor { get; set; }
        string SetShadowColor(bool shadow, string shadowColor);
    }
}
