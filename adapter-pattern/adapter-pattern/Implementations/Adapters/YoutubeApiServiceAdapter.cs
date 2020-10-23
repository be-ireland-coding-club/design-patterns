using adapter_pattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace adapter_pattern.Implementations.Adapters
{
    public class YoutubeApiServiceAdapter : IBEApiService
    {
        private YoutubeApiService _youtubeApiService;
        public YoutubeApiServiceAdapter(YoutubeApiService youtubeApiService)
        {
            _youtubeApiService = youtubeApiService;
        }
        public string SearchForSong(string name, string artist)
        {
            return _youtubeApiService.Search(name, artist);
        }
    }
}
