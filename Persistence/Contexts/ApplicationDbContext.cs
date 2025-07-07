using DiligenciaProveedores.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiligenciaProveedores.Persistence.Contexts;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<Provider> Providers => Set<Provider>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
