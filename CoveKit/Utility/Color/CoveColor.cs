using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit
{
    public enum CoveColor
    {
        // Neutrals
        Black,
        White,
        OffWhite,
        LightGray,
        Gray,
        DarkGray,
        Charcoal,
        Slate,
        Ash,
        Steel,
        Silver,
        Concrete,

        // Muted Colors
        MutedRed,
        MutedOrange,
        MutedYellow,
        MutedGreen,
        MutedBlue,
        MutedTeal,
        MutedPurple,
        MutedPink,
        MutedBrown,
        MutedOlive,

        // Bold Accent Colors
        BoldRed,
        BoldOrange,
        BoldYellow,
        BoldGreen,
        BoldBlue,
        BoldCyan,
        BoldMagenta,
        BoldPink,
        BoldLime,
        BoldViolet
    }

    internal static class CoveColorHelper
    {
        public static string GetColorRgba(CoveColor color)
        {
            return color switch
            {
                // Neutrals (Alpha is set to 1 for solid colors)
                CoveColor.Black => "rgba(0, 0, 0, 1)",
                CoveColor.White => "rgba(255, 255, 255, 1)",
                CoveColor.OffWhite => "rgba(240, 240, 240, 1)",
                CoveColor.LightGray => "rgba(208, 208, 208, 1)",
                CoveColor.Gray => "rgba(168, 168, 168, 1)",
                CoveColor.DarkGray => "rgba(112, 112, 112, 1)",
                CoveColor.Charcoal => "rgba(64, 64, 64, 1)",
                CoveColor.Slate => "rgba(46, 46, 46, 1)",
                CoveColor.Ash => "rgba(136, 136, 136, 1)",
                CoveColor.Steel => "rgba(90, 90, 90, 1)",
                CoveColor.Silver => "rgba(192, 192, 192, 1)",
                CoveColor.Concrete => "rgba(153, 153, 153, 1)",

                // Muted Colors
                CoveColor.MutedRed => "rgba(176, 74, 74, 1)",
                CoveColor.MutedOrange => "rgba(192, 135, 68, 1)",
                CoveColor.MutedYellow => "rgba(201, 179, 73, 1)",
                CoveColor.MutedGreen => "rgba(107, 142, 99, 1)",
                CoveColor.MutedBlue => "rgba(74, 122, 158, 1)",
                CoveColor.MutedTeal => "rgba(78, 126, 127, 1)",
                CoveColor.MutedPurple => "rgba(126, 74, 132, 1)",
                CoveColor.MutedPink => "rgba(158, 74, 122, 1)",
                CoveColor.MutedBrown => "rgba(127, 90, 68, 1)",
                CoveColor.MutedOlive => "rgba(127, 123, 74, 1)",

                // Bold Colors
                CoveColor.BoldRed => "rgba(255, 0, 0, 1)",
                CoveColor.BoldOrange => "rgba(255, 127, 0, 1)",
                CoveColor.BoldYellow => "rgba(255, 255, 0, 1)",
                CoveColor.BoldGreen => "rgba(0, 255, 0, 1)",
                CoveColor.BoldBlue => "rgba(0, 0, 255, 1)",
                CoveColor.BoldCyan => "rgba(0, 255, 255, 1)",
                CoveColor.BoldMagenta => "rgba(255, 0, 255, 1)",
                CoveColor.BoldPink => "rgba(255, 20, 147, 1)",
                CoveColor.BoldLime => "rgba(191, 255, 0, 1)",
                CoveColor.BoldViolet => "rgba(148, 0, 211, 1)",

                _ => "rgba(0, 0, 0, 1)" // Default to black
            };
        }
    }

}
