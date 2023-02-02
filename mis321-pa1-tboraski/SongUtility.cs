using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace mis321_pa1_tboraski
{
    public class SongUtility
    {
        public List<Song> songs;

        private SongFileHandler fileHandler = new SongFileHandler();

        public SongUtility()
        {
            songs = fileHandler.songs;
            SortSongs();
        }

        public void DisplaySongs()
        {
            foreach (Song song in songs)
            {
                if (!song.Favorited)
                {
                    System.Console.WriteLine(song.ToString());
                }
                else
                {
                    System.Console.WriteLine(song.ToString());
                }
            }
        }
        public void AddSong()
        {
            Song newSong = new Song();
            System.Console.WriteLine("  SONG ID:");
            newSong.SongID = Console.ReadLine();
            System.Console.WriteLine("  ARTIST:");
            newSong.Artist = Console.ReadLine();
            System.Console.WriteLine("  SONG NAME:");
            newSong.SongName = Console.ReadLine();
            System.Console.WriteLine("  DATE ADDED:");
            newSong.DateAdded = Console.ReadLine();
            newSong.Favorited = false;
            songs.Add(newSong);
            SortSongs();
            SaveSongs();
        }
        public void FavoriteSong()
        {
            System.Console.WriteLine("  ENTER SONG NAME TO FAVORITE:");
            string userInput = Console.ReadLine();
            Song song = FindSong(userInput);
            if (song == null)
            {
                System.Console.WriteLine("  SONG NOT FOUND");
            }
            else
            {
                song.Favorited = true;
                SaveSongs();
            }
        }
        public void DeleteSong()
        {
            System.Console.WriteLine("  ENTER SONG NAME TO DELETE:");
            string userInput = Console.ReadLine();
            Song song = FindSong(userInput);
            if (song == null)
            {
                System.Console.WriteLine("  SONG NOT FOUND");
            }
            else
            {
                song.Deleted = true;
                SaveSongs();
            }
        }

        private Song FindSong(string searchVal)
        {
            Song returnVal = songs.Find(x => x.SongName.ToLower() == searchVal.ToLower());
            return returnVal;
        }

        private void SaveSongs()
        {
            fileHandler.SaveAllSongs();
        }

        private void SortSongs()
        {
            songs.Sort((x, y) => y.DateAdded.CompareTo(x.DateAdded));
        }
    }
}