using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summary_OOP
{
    internal class Playlist
    {
        public string name {  get; set; }

        public List<Track> tracks { get; set; }

        public Playlist(string name)
        {
            this.name = name;
            tracks = new List<Track>();
        }             
    }
}
