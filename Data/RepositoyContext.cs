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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>();
        }
    }
