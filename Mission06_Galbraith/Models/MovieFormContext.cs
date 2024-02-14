using Microsoft.EntityFrameworkCore;

namespace Mission06_Galbraith.Models
{
    public class MovieFormContext: DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options) //Constructor
        { 
        }

        public DbSet<Form> Form { get; set; }
    }
}