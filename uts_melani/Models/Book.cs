namespace uts_melani.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }

        public Book(string title, Genre genre)
        {
            Title = title;
            Genre = genre;
        }

    }

    







}
