using System;
using System.Collections.Generic;
using System.Text;

namespace adapter_pattern.Implementations
{
    public class SpotifyApiService
    {
        public string SearchForSong(string name, string artist, bool success = true)
        {
            return string.Format("This calls Spotify API to search for song {0} from artist {1}", name, artist);
        }
    }
}
