using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoveKit.Tests.Unit.Components.Input.Text
{
    public class CoveTextInputUnitTests
    {
        [Fact]
        public void CoveTextInput_RendersWithCorrectAttributes()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CoveTextInput>(parameters => parameters
                .Add(p => p.Value, "TestValue")
                .Add(p => p.Placeholder, "Enter some text here...")
                .Add(p => p.Class, "custom-class")
                .Add(p => p.Style, "custom-style"));

            // Assert
            var input = cut.Find("input");
            Assert.Equal("text", input.GetAttribute("type"));
            Assert.Equal("TestValue", input.GetAttribute("value"));
            Assert.Equal("Enter some text here...", input.GetAttribute("placeholder"));
            Assert.Contains("custom-class", input.GetAttribute("class"));
            Assert.Contains("custom-style", input.GetAttribute("style"));
        }
    }
}
