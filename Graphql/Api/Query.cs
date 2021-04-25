using graphql.Domain;

namespace graphql.Api
{
    public class Query
    {
        public Movie GetMovie() =>
            new Movie("Udaan", new Director("Vikramaditya Motwane"));
    }
}