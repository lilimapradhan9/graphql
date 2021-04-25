using System.Threading.Tasks;
using graphql.Domain;
using graphql.Model;
using graphql.Repository;
using HotChocolate;

namespace graphql.Api
{
    public class Mutation
    {
        public async Task<AddMoviePayload> AddMovieAsync(
            AddMovieInput input,
            [Service] ApplicationDbContext context)
        {
            var movie = new Movie
            (
                input.Title,
                input.Director
            );

            context.Movies.Add(movie);
            await context.SaveChangesAsync();

            return new AddMoviePayload(movie);
        }
    }
}