using Assignment_6;
using Microsoft.EntityFrameworkCore;

public class PersonContext : DbContext
{
    public DbSet<Person> People { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=people.db");
}
