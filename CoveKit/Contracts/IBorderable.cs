using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    internal interface IBorderable
    {
        bool Border { get; set; }
        CoveColor BorderColor { get; set; }
        string SetBorderColor(bool border, CoveColor borderColor);
    }
}
