using System.Collections.Generic;
using System.Linq;
using Assignment_6;

public class PersonListDataSource : IPersonDataSource
{
    private readonly List<Person> _people = new List<Person>();

    public PersonListDataSource()
    {
        _people.Add(new Person { Id = 1, Name = "Alice Example", Phone = "111-111-1111" });
        _people.Add(new Person { Id = 2, Name = "Bob Example", Phone = "222-222-2222" });
        _people.Add(new Person { Id = 3, Name = "Cara Example", Phone = "333-333-3333" });
    }

    public IEnumerable<Person> GetPeople() => _people.ToList();

    public IEnumerable<Person> GetPeople(string? filter)
    {
        if (string.IsNullOrWhiteSpace(filter)) return GetPeople();
        var lower = filter.ToLower();
        return _people.Where(p => p.Name != null && p.Name.ToLower().Contains(lower)).ToList();
    }

    public void SaveChanges()
    {
      
    }
}
