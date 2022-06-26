using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder opts)
    {
        opts.UseSqlServer("Server=(local)\\sql2019;Database=MyTestDb;Integrated Security=true;"); 
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<MyEntity>().HasKey(i => new { i.KeyCol1, i.KeyCol2 });
        builder.Entity<MyEntity>().Property(i => i.KeyCol1).UseCollation("Latin1_General_100_BIN2");
        base.OnModelCreating(builder);
    }
}


