using System.Data.Entity;

public class FrikandelContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    public FrikandelContext() : base("Frikandel")
    {

    }

}

