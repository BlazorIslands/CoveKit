using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit.Tests.Unit.Components.Card
{
    public class CoveCardUnitTests
    {
        [Fact]
        public void CoveCard_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveCard>(parameters => parameters
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var div = cut.Find("div");
            Assert.Contains("custom-class", div.GetAttribute("class"));
            Assert.Contains("custom-style", div.GetAttribute("style"));
        }
    }
}
