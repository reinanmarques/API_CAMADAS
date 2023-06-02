using CRUD_ESTUDANTES.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Persistence;

public class CrudDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public CrudDbContext(DbContextOptions<CrudDbContext> options) :base(options)
    {
    
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Student>(e =>
        {
            e.HasKey(es => es.Id);

            e.Property(es => es.Name)
                .IsRequired(true)
                .HasMaxLength(200);
        });
        
    
    }
}