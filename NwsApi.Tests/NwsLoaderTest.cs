using System;
using System.IO;
using FakeItEasy;
using NwsApi.Models;
using Xunit;

namespace NwsApi.Tests
{
    /// <summary>
    /// Many (most) of the tests in here are not meant to be unit tests and are closer to integration tests.
    /// They help with ensuring the parsing is going correctly and the types are correct
    /// </summary>
    public class NwsLoaderTest
    {
        [Fact]
        public void NwsLoader_LoadPoint1_EverythingIsFine()
        {
            // Arrange
            var nwsDataLoader = A.Fake<INwsDataLoader>();
            A.CallTo(() => nwsDataLoader.GetResponseStream("/points/43.05,-89.52"))
                .Returns(File.Open("./TestResponses/nwsPoint.json", FileMode.Open));

            var nwsLoader = new NwsLoader(nwsDataLoader);

            NwsPoint actual = null;

            // Act
            actual = nwsLoader.PointData(43.05, -89.52);

            // Assert
            // Don't test everything since there's a lot of data and typing
            Assert.Equal("MKX", actual.CountyWarningArea);
            Assert.Equal(new Uri("https://api.weather.gov/offices/MKX"), actual.ForecastOffice);
            Assert.Equal(33, actual.GridX);
            Assert.Equal(30, actual.GridY);
            Assert.Equal(new Uri("https://api.weather.gov/gridpoints/MKX/33,30/forecast"), actual.Forecast);
            Assert.Equal(new Uri("https://api.weather.gov/gridpoints/MKX/33,30/forecast/hourly"), actual.ForecastHourly);
            Assert.Equal(new Uri("https://api.weather.gov/gridpoints/MKX/33,30"), actual.ForecastGridData);
            Assert.Equal(new Uri("https://api.weather.gov/gridpoints/MKX/33,30/stations"), actual.ObservationStations);
            Assert.Equal("Middleton", actual.RelativeLocation.City);
            Assert.Equal("WI", actual.RelativeLocation.State);
            Assert.Equal(new Uri("https://api.weather.gov/zones/forecast/WIZ063"), actual.ForecastZone);
            Assert.Equal(new Uri("https://api.weather.gov/zones/county/WIC025"), actual.County);
            Assert.Equal(new Uri("https://api.weather.gov/zones/fire/WIZ063"), actual.FireWeatherZone);
            Assert.Equal("America/Chicago", actual.TimeZone);
            Assert.Equal("KMKX", actual.RadarStation);
        }
    }
}
