using Leaflex.Web.Pages;
using Leaflex.Web.S3;
using Microsoft.AspNetCore.Components.Testing;
using Xunit;

namespace Leaflex.Web.Tests.S3
{
    public class ListTests
    {
        private readonly TestHost _host = new TestHost();

        [Fact]
        public void Thing()
        {
            var component = _host.AddComponent<Counter>();
            Assert.Equal("Current count: 0", component.Find("p").InnerText);
        }

        [Fact]
        public void CanIncrementCount()
        {
            var component = _host.AddComponent<Counter>();

            component.Find("button").Click();
            Assert.Equal("Current count: 1", component.Find("p").InnerText);
        }
    }
}