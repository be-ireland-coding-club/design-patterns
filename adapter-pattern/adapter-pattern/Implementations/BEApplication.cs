using adapter_pattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace adapter_pattern.Implementations
{
    public class BEApplication
    {
        private IBEApiService _apiService;
        public BEApplication(IBEApiService apiServiceAdapter)
        {
            _apiService = apiServiceAdapter;
        }
        public string FindSongs(string name, string artist)
        {
            return _apiService.SearchForSong(name, artist);
        }
    }
}
