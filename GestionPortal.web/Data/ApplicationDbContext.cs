using GestionPortal.web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionPortal.web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
