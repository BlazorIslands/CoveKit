using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit.Tests.Unit.Components.Input.Numeric
{
    public class CoveIntegerInputUnitTests
    {
        [Fact]
        public void CoveIntegerInput_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveIntegerInput>(parameters => parameters
                .Add(p => p.Value, 7)
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var input = cut.Find("input");
            Assert.Equal("number", input.GetAttribute("type"));
            Assert.Equal("7", input.GetAttribute("value"));
            Assert.Contains("custom-class", input.GetAttribute("class"));
            Assert.Contains("custom-style", input.GetAttribute("style"));
        }
    }
}
