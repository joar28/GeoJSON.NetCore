using System;
using GeoJSON.Net;
using GeoJSON.Net.Geometry;
using Newtonsoft.Json;
using Xunit;

namespace GeoJSON.NetCoreTests
{
    public class GeoJsonTests
    {
        [Fact]
        public void GeoJsonExistsTests()
        {
            string json = "{\"coordinates\":[-2.124156,51.899523],\"type\":\"Point\"}";

            Point point = JsonConvert.DeserializeObject<Point>(json);

            Assert.NotNull(point);
        }
    }
}