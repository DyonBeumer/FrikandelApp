using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FrikandelApp
{
    public class FrikandelContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public FrikandelContext() : base("Frikandel")
        {

        }

    }
}
