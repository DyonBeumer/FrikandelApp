using Dapper.Contrib.Extensions;

[Table("People")]
public class Person
{

    public int Id { get; set; }
    public string Name { get; set; }
}

