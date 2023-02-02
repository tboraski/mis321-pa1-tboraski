using Newtonsoft.Json;
namespace mis321_pa1_tboraski
{
    public class SongFileHandler
    {
        public List<Song> songs;

        public SongFileHandler()
        {
            GetAllSongs();
        }

        public void GetAllSongs()
        {
            string json = File.ReadAllText("songs.json");
            songs = JsonConvert.DeserializeObject<List<Song>>(json);

            try
            {
                if (json == null)
                {
                    System.Console.WriteLine("Unsuccessful");
                }
                else
                {
                    System.Console.WriteLine("Successful");
                }

            }
            catch (IOException e)
            {
                System.Console.WriteLine(e.GetBaseException());
            }
        }

        public void SaveAllSongs()
        {
            File.WriteAllText("songs.json", JsonConvert.SerializeObject(songs));
        }
    }
}