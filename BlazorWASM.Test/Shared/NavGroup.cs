namespace BlazorWASM.Test.Shared
{
    public class NavGroup
    {
        public string Name { get; set; }
        public List<NavLinkItem> Links { get; set; } = new List<NavLinkItem>();
    }

    public class NavLinkItem
    {
        public string Href { get; set; }
        public string Text { get; set; }
    }
}
