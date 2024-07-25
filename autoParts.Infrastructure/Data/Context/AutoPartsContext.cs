using Microsoft.EntityFrameworkCore;

namespace autoParts.Infrastructure.Data.Context;

public class AutoPartsContext(DbContextOptions<AutoPartsContext> options) : DbContext(options)
{
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutoPartsContext).Assembly);
    }
}