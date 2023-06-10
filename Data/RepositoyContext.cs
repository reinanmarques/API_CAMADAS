using CRUD_ESTUDANTES.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Persistence;

    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            :base(options)
        {
        }

        public DbSet<Course>? Courses { get; set; }
        public DbSet<Student>? Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        
        
        builder.Entity<Course>(e =>
        {
            e.HasKey(co => co.Id);

            e.Property(es => es.Name)
                .IsRequired(true)
                .HasMaxLength(200);

        });
        
        builder.Entity<Student>(e =>
        {
            e.HasKey(es => es.Id);

            e.Property(es => es.Name)
                .IsRequired(true)
                .HasMaxLength(200);

             e.Property(es => es.Email)
                .IsRequired(true)
                .HasMaxLength(200);
    
                e.Property(es => es.Password)
                .IsRequired(true)
                .HasMaxLength(200);

                e.HasOne(es => es.Course)
                    .WithOne()
                    .HasForeignKey<Course>(co => co.Id)
                    .IsRequired(true);

        });

    }}
