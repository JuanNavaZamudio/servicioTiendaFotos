using Microsoft.EntityFrameworkCore;

public class PostContext : DbContext
{
    public DbSet<StorePost> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=store.db");
}