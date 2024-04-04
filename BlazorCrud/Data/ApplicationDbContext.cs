using BlazorCrud.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {   
        }

        // colocar cada modelo
        public DbSet<Libro> Libro { get; set; }
    }
}
