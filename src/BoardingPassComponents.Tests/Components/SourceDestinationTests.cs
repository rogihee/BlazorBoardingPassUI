using AngleSharp.Css.Dom;
using AngleSharp.Dom;
using BoardingPassComponents.Components;
using Bunit;
using NUnit.Framework;

namespace BoardingPassComponents.Tests.Components
{
    public class SourceDestinationTests : BUnitTestContext
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CityAirportCodeCorrectly()
        {
            // Arrange
            // Done by base class

            // Act
            var cut = RenderComponent<SourceDestination>(parameters => parameters                    
                    .Add(p => p.City, "Delft")
                    .Add(p => p.AirportCode, "RTM")
            );

            var spans = cut.FindAll("span");

            // Assert
            Assert.AreEqual(2, spans.Count);
            Assert.AreEqual("Delft", spans[0].InnerHtml);
            Assert.AreEqual("RTM", spans[1].InnerHtml);
        }

        [Test]
        public void AlignCityRightCorrectly()
        {
            // Arrange
            // Done by base class

            // Act
            var cut = RenderComponent<SourceDestination>(parameters => parameters
                .Add(p => p.City, "Delft")
                .Add(p => p.AlignCityRight, true)
            );

            var spans = cut.FindAll("span");

            // Assert
            Assert.AreEqual(2, spans.Count);
            Assert.AreEqual("Delft", spans[0].InnerHtml);
            Assert.True(spans[0].HasAttribute("style"));
            Assert.AreEqual("text-align:end;", spans[0].Attributes.GetNamedItem("style").Value);
        }
    }
}