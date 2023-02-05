// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using Dapper;

var sql = "select * from Orders";
var orderes = new List<Order>();
using (var dbConn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=Frikandel;Integrated Security=SSPI;"))
{
    dbConn.Open();
    orderes = dbConn.Query<Order>(sql).ToList();
}

Console.WriteLine(orderes.Count);