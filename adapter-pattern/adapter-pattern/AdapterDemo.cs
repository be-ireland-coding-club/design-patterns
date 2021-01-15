using adapter_pattern.Implementations;
using adapter_pattern.Implementations.Adapters;
using adapter_pattern.Interface;
using System;

namespace adapter_pattern
{
    class AdapterDemo
    {
        static void Main(string[] args)
        {
            SpotifyApiService spotifyApiService = new SpotifyApiService();
            IBEApiService adapter = new SpotifyApiServiceAdapter(spotifyApiService);
            BEApplication app = new BEApplication(adapter);
            Console.WriteLine(app.FindSongs("Sail", "AWOLNATION"));
            
            YoutubeApiService youtubeApiService = new YoutubeApiService();
            adapter = new YoutubeApiServiceAdapter(youtubeApiService);
            app = new BEApplication(adapter);
            Console.WriteLine(app.FindSongs("Burn It Down", "Linkin Park"));
        }
    }
}
