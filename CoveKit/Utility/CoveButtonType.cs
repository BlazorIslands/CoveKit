using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    public enum CoveButtonType
    {
        Button,
        Submit,
        Reset
    }

    internal class CoveButtonTypeHelper
    {
        public static string GetButtonType(CoveButtonType type)
        {
            switch (type)
            {
                case CoveButtonType.Button:
                    return "button";
                case CoveButtonType.Submit:
                    return "submit";
                case CoveButtonType.Reset:
                    return "reset";
                default:
                    return "button";
            }
        }
    }
}
