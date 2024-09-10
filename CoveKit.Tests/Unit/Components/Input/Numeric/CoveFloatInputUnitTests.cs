using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit.Tests.Unit.Components.Input.Numeric
{
    public class CoveFloatInputUnitTests
    {
        [Fact]
        public void CoveFloatInput_Float_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveFloatInput<float>>(parameters => parameters
                .Add(p => p.Value, 7.77f)
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var input = cut.Find("input");
            Assert.Equal("number", input.GetAttribute("type"));
            Assert.Equal("7.77", input.GetAttribute("value"));
            Assert.Contains("custom-class", input.GetAttribute("class"));
            Assert.Contains("custom-style", input.GetAttribute("style"));
        }

        [Fact]
        public void CoveFloatInput_Double_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveFloatInput<double>>(parameters => parameters
                .Add(p => p.Value, 7.77)
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var input = cut.Find("input");
            Assert.Equal("number", input.GetAttribute("type"));
            Assert.Equal("7.77", input.GetAttribute("value"));
            Assert.Contains("custom-class", input.GetAttribute("class"));
            Assert.Contains("custom-style", input.GetAttribute("style"));
        }

        [Fact]
        public void CoveFloatInput_Decimal_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveFloatInput<decimal>>(parameters => parameters
                .Add(p => p.Value, 7.77m)
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var input = cut.Find("input");
            Assert.Equal("number", input.GetAttribute("type"));
            Assert.Equal("7.77", input.GetAttribute("value"));
            Assert.Contains("custom-class", input.GetAttribute("class"));
            Assert.Contains("custom-style", input.GetAttribute("style"));
        }
    }
}
