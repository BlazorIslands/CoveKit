namespace CoveKit 
{
    internal interface IFontable 
    {
        
        CoveFont Font { get; set; }
        CoveFontSize FontSize { get; set; }
        string SetFont(CoveFont coveFont);
        string SetFontSize(CoveFontSize coveFontSize);
    }
}