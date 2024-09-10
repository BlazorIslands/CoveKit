using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit.Tests.Unit.Components.Button
{
    public class CoveButtonUnitTests
    {
        [Fact]
        public void CoveButton_Button_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveButton>(parameters => parameters
                .Add(p => p.Type, CoveButtonType.Button)
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var button = cut.Find("button");
            Assert.Equal("button", button.GetAttribute("type"));
            Assert.Contains("custom-class", button.GetAttribute("class"));
            Assert.Contains("custom-style", button.GetAttribute("style"));
        }

        [Fact]
        public void CoveButton_Submit_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveButton>(parameters => parameters
                .Add(p => p.Type, CoveButtonType.Submit)
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var button = cut.Find("button");
            Assert.Equal("submit", button.GetAttribute("type"));
            Assert.Contains("custom-class", button.GetAttribute("class"));
            Assert.Contains("custom-style", button.GetAttribute("style"));
        }

        [Fact]
        public void CoveButton_Reset_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveButton>(parameters => parameters
                .Add(p => p.Type, CoveButtonType.Reset)
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var button = cut.Find("button");
            Assert.Equal("reset", button.GetAttribute("type"));
            Assert.Contains("custom-class", button.GetAttribute("class"));
            Assert.Contains("custom-style", button.GetAttribute("style"));
        }
    }
}
