using Microsoft.EntityFrameworkCore;

public class PostContext : DbContext
{
    public DbSet<StorePost> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL(@"server=localhost;database=plantstore;user=pruebasmysql;password=toor");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<StorePost>(entity=>{
          entity.HasKey(e => e.id);
      });
    }
}