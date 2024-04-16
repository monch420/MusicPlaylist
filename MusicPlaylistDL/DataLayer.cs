using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataLayer
{
    public class PlaylistDataLayer
    {
        List<Song> songs = new List<Song>();

        public PlaylistDataLayer()
        {
            CreateListOfSongs();
        }

        private void CreateListOfSongs()
        {
            Song FirstSong = new Song { title = "DIFFERENT DAY", artist = "Playboi Carti", album = "UTOPIA", duration = "2:48" };
            songs.Add(FirstSong);

            Song SecondSong = new Song { title = "I KNOW ?", artist = "Travis Scott", album = "I AM MUSIC", duration = "3:31" };
            songs.Add(SecondSong);

            Song ThirdSong = new Song { title = "If We Being Real", artist = "Yeat", album = "2093", duration = "2:52" };
            songs.Add(ThirdSong);

            Song FourthSong = new Song { title = "Jennifer's Body", artist = "Ken Carson", album = "A Great Chaos", duration = "2:38" };
            songs.Add(FourthSong);

            Song FifthSong = new Song { title = "Moonlight", artist = "XXXTENTACION", album = "?", duration = "2:14" };
            songs.Add(FifthSong);

            Song SixthSong = new Song { title = "OUTTA THERE", artist = "Rich Amiri", album = "Ghetto Fabulous", duration = "2:12" };
            songs.Add(SixthSong);
        }

        public Song GetSong(string songTitle)
        {
            Song foundTitle = new Song();

            foreach (var song in songs)
            {
                if (song.title.Equals(songTitle, StringComparison.OrdinalIgnoreCase))
                {
                    foundTitle = song;
                }
            }
            return foundTitle;
        }

        public List<Song> ReturnPlaylistInformation()
        {
            return songs;
        }

        public List<Song> DeleteSong(string songTitle)
        {
            PlaylistDataLayer dataLayer = new PlaylistDataLayer();

            foreach (var deleteSong in songs)
            {
                if (deleteSong.title.Equals(songTitle, StringComparison.OrdinalIgnoreCase))
                {
                    songs.Remove(deleteSong);
                    break;
                }
            }
            return songs;
        }

        public List<Song> AddSong(string userTitle, string userArtist)
        {
            Song UserSong = new Song { title = userTitle, artist = userArtist };
            songs.Add(UserSong);
            return songs;
        }
    }
}
