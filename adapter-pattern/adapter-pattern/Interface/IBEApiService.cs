using System;
using System.Collections.Generic;
using System.Text;

namespace adapter_pattern.Interface
{
    public interface IBEApiService
    {
        string SearchForSong(string name, string artist);
    }
}
