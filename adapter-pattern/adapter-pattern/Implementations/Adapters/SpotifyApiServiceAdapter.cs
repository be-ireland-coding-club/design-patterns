using adapter_pattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace adapter_pattern.Implementations.Adapters
{
    public class SpotifyApiServiceAdapter : IBEApiService
    {
        private SpotifyApiService _spotifyApiService;
        public SpotifyApiServiceAdapter(SpotifyApiService spotifyApiService)
        {
            _spotifyApiService = spotifyApiService;
        }
        public string SearchForSong(string name, string artist)
        {
            return _spotifyApiService.SearchForSong(name, artist);
        }
    }
}
