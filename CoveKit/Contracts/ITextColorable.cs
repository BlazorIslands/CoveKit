namespace CoveKit 
{
    internal interface ITextColorable 
    {
        object TextColor { get; set; }
        string SetTextColor(object textColor);
    }
}