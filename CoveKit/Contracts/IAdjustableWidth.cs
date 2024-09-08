using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    internal interface IAdjustableWidth
    {
        int Width { get; set; }
        string SetWidth(int width);
    }
}
