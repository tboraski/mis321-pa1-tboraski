namespace mis321_pa1_tboraski
{
    public class Song
    {
        public string SongID { get; set; }
        public string Artist { get; set; }
        public string SongName { get; set; }
        public string DateAdded { get; set; }
        public bool Favorited { get; set; }
        public bool Deleted { get; set; }

        public override string ToString()
        {
            return $"{SongID} \t {Artist} \t {SongName} \t {DateAdded} \t {"Favorited:"} \t {Favorited} \t {"Deleted:"} \t {Deleted}";
        }
    }
}