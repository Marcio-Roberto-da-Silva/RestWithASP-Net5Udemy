using RestWithASPNet5Udemy1.Model;
using System.Collections.Generic;

namespace RestWithASPNet5Udemy1.Repository {
    public interface IPersonRepository : IRepository<Person> 
        {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string secondName);

    }
}
