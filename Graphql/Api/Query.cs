using System.Linq;
using graphql.Domain;
using graphql.Repository;
using HotChocolate;

namespace graphql.Api
{
    public class Query
    {
        public IQueryable<Movie> GetMovies([Service] ApplicationDbContext context) =>
            context.Movies;
    }
}