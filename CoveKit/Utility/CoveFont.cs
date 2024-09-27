namespace CoveKit 
{
    public enum CoveFont 
    {
        Default,
        CourierNew,
        LucidaConsole,
        CascadiaMono,
        Consolas
    }

    public enum CoveFontSize 
    {
        Default,
        Small,
        Medium,
        Large
    }

    internal class CoveFontHelper 
    {
        public static string GetCoveFont(CoveFont type) 
        {
            switch (type) 
            {
                case CoveFont.CourierNew:
                    return "font-family: 'Courier New', monospace;";
                case CoveFont.LucidaConsole:
                    return "font-family: 'Lucida Console', monospace;";
                case CoveFont.CascadiaMono:
                    return "font-family: 'CascadiaMono', monospace;";
                case CoveFont.Consolas:
                    return "font-family: 'Consolas', monospace;";
                default:
                    return "font-family: monospace;";
            }
        }

        public static string GetCoveFontSize(CoveFontSize type) 
        {
            switch (type) 
            {
                case CoveFontSize.Small:
                    return "font-size: 12px;";
                case CoveFontSize.Medium:
                    return "font-size: 16px;";
                case CoveFontSize.Large:
                    return "font-size: 20px;";
                default:
                    return "font-size: 16px;";
            }
        }
    }
}