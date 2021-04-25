namespace graphql.Domain
{
    public class Movie
    {
        public Movie(string title, Director director)
        {
            Title = title;
            Director = director;
        }

        public string Title { get; }
        public Director Director { get; }
    }
}