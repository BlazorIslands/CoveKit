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
        object BorderColor { get; set; }
        string SetBorderColor(bool border, object borderColor);
    }
}
