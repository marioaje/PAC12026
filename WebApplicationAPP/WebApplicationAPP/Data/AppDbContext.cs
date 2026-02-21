using Microsoft.EntityFrameworkCore;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Model de datos de persona en la tabla de mysql
        public DbSet<Persona> Persona { get; set; }
        
    }
}
