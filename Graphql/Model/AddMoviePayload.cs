using graphql.Domain;

namespace graphql.Model
{
    public class AddMoviePayload
    {
        public AddMoviePayload(Movie movie)
        {
            Movie = movie;
        }

        public Movie Movie { get; }
    }
}