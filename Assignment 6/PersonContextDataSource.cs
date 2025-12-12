using System.Collections.Generic;
using System.Linq;
using Assignment_6;
using Microsoft.EntityFrameworkCore;

public class PersonContextDataSource : IPersonDataSource
{
    private readonly PersonContext _context;

    public PersonContextDataSource()
    {
        _context = new PersonContext();
        _context.Database.EnsureCreated();
        _context.People.Load();
    }

    
    public IEnumerable<Person> GetPeople()
    {
    
        return _context.People.Local.ToBindingList();
    }

    public IEnumerable<Person> GetPeople(string? filter)
    {
        if (string.IsNullOrWhiteSpace(filter)) return GetPeople();
        var lower = filter.ToLower();
        return _context.People.Local.Where(p => p.Name != null && p.Name.ToLower().Contains(lower)).ToList();
    }

    public void SaveChanges() => _context.SaveChanges();
}
