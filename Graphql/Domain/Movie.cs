using System.ComponentModel.DataAnnotations.Schema;

namespace graphql.Domain
{
    public class Movie
    {
        public Movie()
        {
        }

        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Title { get; set; }
        public string Director { get; set; }
    }
}