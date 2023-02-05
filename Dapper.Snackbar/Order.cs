using Dapper.Contrib.Extensions;

public class Order
{
    public int Id { get; set; }
    public virtual ICollection<Item> Items { get; set; }
    public virtual Person Orderer { get; set; }
}

