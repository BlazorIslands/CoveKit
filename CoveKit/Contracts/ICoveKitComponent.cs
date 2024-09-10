using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    internal interface ICoveKitComponent
    {
        string? Class { get; set; }
        string? Style { get; set; }
        bool Round { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
    }
}
