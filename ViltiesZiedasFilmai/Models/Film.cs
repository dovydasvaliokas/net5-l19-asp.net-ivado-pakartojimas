namespace ViltiesZiedasFilmai.Models
{
    public class Film
    {
        private FilmContext context;

        public int FilmId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        public int Length { get; set; }

        public string Rating { get; set; }

        public Film(FilmContext context, int filmId, string title, string description, int releaseYear, int length, string rating)
        {
            this.context = context;
            FilmId = filmId;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Length = length;
            Rating = rating;
        }

        public Film(int filmId, string title, string description, int releaseYear, int length, string rating)
        {
            FilmId = filmId;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Length = length;
            Rating = rating;
        }

        public Film()
        {
        }
    }
}
