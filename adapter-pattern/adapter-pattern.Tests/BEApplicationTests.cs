using Microsoft.VisualStudio.TestTools.UnitTesting;
using adapter_pattern.Implementations;
using adapter_pattern.Interface;
using adapter_pattern.Implementations.Adapters;

namespace adapter_pattern.Tests
{
    [TestClass]
    public class BEApplicationTests
    {
        [TestMethod]
        public void FindSongs_FromSpotify()
        {
            //Arrange
            string name = "Sail";
            string artist = "AWOLNATION";
            string expectedResponse = "This calls Spotify API to search for song Sail from artist AWOLNATION";
            SpotifyApiService spotifyApiService = new SpotifyApiService();
            IBEApiService adapter = new SpotifyApiServiceAdapter(spotifyApiService);
            BEApplication app = new BEApplication(adapter);

            //Act
            string response = app.FindSongs(name, artist);

            //Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void FindSongs_FromYoutube()
        {
            //Arrange
            string name = "Sail";
            string artist = "AWOLNATION";
            string expectedResponse = "This calls Youtube API to search for song Sail from artist AWOLNATION";
            YoutubeApiService youtubeApiService = new YoutubeApiService();
            IBEApiService adapter = new YoutubeApiServiceAdapter(youtubeApiService);
            BEApplication app = new BEApplication(adapter);

            //Act
            string response = app.FindSongs(name, artist);

            //Assert
            Assert.AreEqual(response, expectedResponse);
        }
    }
}
