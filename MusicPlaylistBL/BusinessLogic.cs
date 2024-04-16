using DataLayer;
using System.Collections.Generic;
using System;
using Model;

namespace BusinessLogic
{
    public class PlaylistBusinessLogic
    {
        public bool VerifySong(string songTitle)
        {
            PlaylistDataLayer dataLayer = new PlaylistDataLayer();
            var result = dataLayer.GetSong(songTitle);

            return result.title != null ? true : false;
        }

        public List<Song> DisplayPlaylistInfo()
        {
            PlaylistDataLayer dataLayer = new PlaylistDataLayer();

            return dataLayer.ReturnPlaylistInformation();
        }

        public List<Song> RemovedSongInList(string songTitle)
        {
            PlaylistDataLayer dataLayer = new PlaylistDataLayer();
            var newRemovedList = dataLayer.DeleteSong(songTitle);

            return newRemovedList;
        }

        public List<Song> AddedSongInList (string userTitle, string userArtist)
        {
            PlaylistDataLayer dataLayer = new PlaylistDataLayer();
            var newAddedList = dataLayer.AddSong(userTitle, userArtist);

            return newAddedList;
        }
    }
}
