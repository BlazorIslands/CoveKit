using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    internal interface IBackgroundable
    {
        CoveColor BackgroundColor { get; set; }
        string SetBackgroundColor(CoveColor backgroundColor);
    }
}
