using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

public class Program
{
    private static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<DbWorker>();

    }
}

[SimpleJob]
public class DbWorker
{
    [Benchmark]
    public void DoDbWork()
    {
        using (var context = new FrikandelContext())
        {
            var snackbar = new List<string> { "Mexicano", "Kroket", "Friet", "Kaassouflééééé" };
            var people = new List<Person> { new() { Name = "Sjaak" }, new() { Name = "Emma" }, new() { Name = "아이유" } };
            var random = new Random();
            var chosen = random.Next(3, 20);
            var order = new Order
            {
                Orderer = people[random.Next(people.Count)],
                Items = new List<Item>()
            };
            for (int i = 0; i < chosen; i++)
            {

                var item = new Item
                {
                    Name = snackbar[random.Next(snackbar.Count)],
                    Price = (new(random.NextDouble() * 100)),
                };
                order.Items.Add(item);
            }
            context.People.AddRange(people);
            context.Items.AddRange(order.Items);
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}