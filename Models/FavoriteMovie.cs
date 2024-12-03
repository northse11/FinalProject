namespace FinalProject.Models
{
    public class FavoriteMovie
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public FavoriteMovie() { }

        public FavoriteMovie(int? id, string title, string director, DateTime releaseDate, string genre, double rating)
        {
            ID = id;
            Title = title;
            Director = director;
            ReleaseDate = releaseDate;
            Genre = genre;
            Rating = rating;
        }
    }
}
