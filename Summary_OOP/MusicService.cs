using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summary_OOP
{
    internal class MusicService
    {
        public string nameMusicService {  get; set; }

        public List<Playlist> playlists { get; set; }

        public MusicService(string nameMusicService)
        {
            this.nameMusicService = nameMusicService;
            playlists = new List<Playlist>();
        }
    }
}
