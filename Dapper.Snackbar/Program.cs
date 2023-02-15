// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using static Dapper.Contrib.Extensions.SqlMapperExtensions;

var orderes = new List<Order>();

using (var dbConn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=Frikandel;Integrated Security=SSPI;"))
{
    dbConn.Open();
    var snackbar = new List<string> { "Mexicano", "Kroket", "Friet", "Kaassouflééééé" };
    var people = new List<Person> { new() { Name = "Sjaak" }, new() { Name = "Emma" }, new() { Name = "아이유" } };
    var random = new Random();
    var chosen = random.Next(3, 20);
    var items = new List<Item>();

    var order = new Order
    {
        Orderer = people[random.Next(people.Count)],
        Items = items
    };
    for (int i = 0; i < chosen; i++)
    {

        var item = new Item
        {
            Name = snackbar[random.Next(snackbar.Count)],
            Price = (new(random.NextDouble() * 100)),

        };
        dbConn.Execute(
                    "INSERT INTO Item (Id, Name, Price) VALUES (@Id, @Name, @Price)",
                    item);
    }


    dbConn.Insert<IEnumerable<Person>>(people); 
    // Dont know how to map relationschips
    dbConn.Insert<IEnumerable<Item>>(items);
    // Dont know how to map relationschips
    dbConn.Insert<Order>(order/*, (person) => { order.Orderer = person; }, splitOn: ""*/);
}

Console.WriteLine(orderes.Count);