using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Summary_OOP
{
    internal class MusicManager
    {
        private List<Track> tracks;
        private List<Playlist> playlists;
        private List<Author> authors;

        public MusicManager()
        {
            tracks = new List<Track>();
            authors = new List<Author>();
            playlists = new List<Playlist>();
        }
        
        public void AddTrack(Track track)
        {
            tracks.Add(track);
            Console.WriteLine($"Track {track.name} added");
        }

        public void UpdateTrack(string trackName, string newNameTrack, int newDuration, Author author)
        {
            Track existingTrac = tracks.Find(t => t.name == trackName);

            if (existingTrac != null)   
           {
                existingTrac.name = newNameTrack;
                existingTrac.duration = newDuration;
                existingTrac.author = author;
                Console.WriteLine($"Info with track {trackName} update");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public void DeleteTrack(string trackName)
        {
            Track trackToRemove = tracks.Find(t => t.name == trackName);

            if(trackToRemove != null)
            {
                tracks.Remove(trackToRemove);
                Console.WriteLine($"Track {trackName} delete!");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public void ViewAllTracks()
        {
            if(tracks.Count == 0)
            {
                Console.WriteLine("There is no track");
                return;
            }
            Console.WriteLine("List all tracks");

            foreach (var track in tracks)
            {
                Console.WriteLine(track.name, track.duration, track.author);
            }
        }

        public void AddPlaylast(Playlist playlist)
        {
            playlists.Add(playlist);
            Console.WriteLine("Playlist is added!");
        }

        public void UpdatePlaylist(string playlistName, Playlist updatePlaylist)
        {
            Playlist existingPlaylist = playlists.Find(t => t.name == playlistName);

            if(existingPlaylist != null)
            {
                existingPlaylist.name = updatePlaylist.name;
                Console.WriteLine("Playlist is update");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public void DeletePlaylist(string playlistName)
        {
            Playlist playlistToRemove = playlists.Find(p => p.name ==  playlistName);

            if (playlistToRemove != null)
            {
                playlists.Remove(playlistToRemove);
                Console.WriteLine($"Playlist {playlistName} is delete!");
            }
        }

        public void AddAuthor(Author author)
        {
            authors.Add(author);
            Console.WriteLine("Added Author");
        }
    }
}
