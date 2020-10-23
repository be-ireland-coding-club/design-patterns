using System;
using System.Collections.Generic;
using System.Text;

namespace adapter_pattern.Implementations
{
    public class YoutubeApiService
    {
        public string Search(string name, string artist)
        {
            return string.Format("This calls Youtube API to search for song {0} from artist {1}", name, artist);
        }
    }
}
