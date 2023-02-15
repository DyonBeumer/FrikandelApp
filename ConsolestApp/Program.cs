using System.Text.Json.Serialization;
using MediatR;

Console.WriteLine("Hello, World!");

public class Meta
{
    public Dictionary<int, int> D2d { get; set; } = new Dictionary<int, int>();

    public int this[int i]
    {
        get { return D2d[i]; }
        set { D2d[i] = value; }
    }
}

public class PersonRequester : ISender
{
    public IAsyncEnumerable<TResponse> CreateStream<TResponse>(IStreamRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<object?> CreateStream(object request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest
    {
        throw new NotImplementedException();
    }

    public Task<object?> Send(object request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

public class PersonRequest : IRequest<Person>
{

}

public class PersonRequestHandler : IRequestHandler<PersonRequest, Person>
{
    Task<Person> IRequestHandler<PersonRequest, Person>.Handle(PersonRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Person 
        { 
            FirstName = "Gerri",
            LastName = "Eickhof",
            Id = new Meta { [111] = 321 }
        });
    }
}

public class Person
{
    public Meta Id { get; set; } = new();

    [JsonPropertyName("FirstName")]
    public string FirstName { get; set; } = string.Empty;

    [JsonPropertyName("LastName")]
    public string LastName { get; set; } = string.Empty;
}