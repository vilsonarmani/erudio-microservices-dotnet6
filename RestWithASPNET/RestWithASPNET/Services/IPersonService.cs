
using RestWithASPNET.Model;
namespace RestWithASPNET.Services;

public interface IPersonService
{
    Person Create(Person person);
    Person FindById(long id);
    List<Person> FindAll();
    Person FindByName(string name);
    Person Update(Person person);
    void Delete(long id);
}

