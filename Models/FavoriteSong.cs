namespace FinalProject.Models
{
    public class FavoriteSong
    {
        public int FavoriteSongID { get; set; }
        public int TeamMemberID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }

        // Navigation property
        public TeamMember TeamMember { get; set; }
    }
}
