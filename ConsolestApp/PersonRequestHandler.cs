using MediatR;

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
