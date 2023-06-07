using CRUD_ESTUDANTES.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Persistence;

    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            :base(options)
        {
        }

        public DbSet<Student>? Students { get; set; }
        
       protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Student>(e =>
        {
            e.HasKey(es => es.Id);

            e.Property(es => es.Name)
                .IsRequired(true)
                .HasMaxLength(200);

                  e.Property(es => es.Course)
                .IsRequired(true)
                .HasMaxLength(200);

             e.Property(es => es.Email)
                .IsRequired(true)
                .HasMaxLength(200);

                e.Property(es => es.Password)
                .IsRequired(true)
                .HasMaxLength(200);   
        });
    }}
