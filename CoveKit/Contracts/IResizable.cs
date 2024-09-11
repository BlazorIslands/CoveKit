using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    interface IResizable
    {
        int Width { get; set; }
        int Height { get; set; }
        string SetSize(int width, int height);
    }
}
