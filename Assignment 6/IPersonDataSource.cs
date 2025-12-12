using System.Collections.Generic;
using Assignment_6;

public interface IPersonDataSource
{
    IEnumerable<Person> GetPeople();
    IEnumerable<Person> GetPeople(string? filter);
    void SaveChanges();
}
