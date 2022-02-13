using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementatios;

public class PersonServiceImplementation : IPersonService
{
    private volatile int count;

    public Person Create(Person person)
    {
        //aqui acessaria a base de dados, faria a persistencia e etc
        return person;
    }

    public void Delete(long id)
    {

    }

    public List<Person> FindAll()
    {
        List<Person> persons = new List<Person>();

        for (int i = 0; i < 10; i++)
            persons.Add(MockPerson(i, "/"));

        return persons;
    }
    public Person FindById(long id)
    {
        return MockPerson(1978);
    }

    public Person FindByName(string name)
    {
        return MockPerson(new Random().Next(), name);
    }

    public Person Update(Person person)
    {

        return person;
    }

    private Person MockPerson(int id, string nome = "Vilson")
    {
        return new Person //Mock
        {
            Id = IncrementAndGet(),
            FirstName = nome == "Vilson"? nome:$"Person {id}",
            LastName = $"Lname Person {id}",
            Address = $"Cidade {id} - Estado {id*10} ",
            Gender = (new Random(id).Next() %2==0)? "Male":"Female"
        };

    }

    private long IncrementAndGet()
    {
        return (long)Interlocked.Increment(ref count);
    }
}

