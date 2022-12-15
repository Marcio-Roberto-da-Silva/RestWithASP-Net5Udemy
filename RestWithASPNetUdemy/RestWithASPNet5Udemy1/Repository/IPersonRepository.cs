using RestWithASPNet5Udemy1.Controllers;
using RestWithASPNet5Udemy1.Model;
using System.Collections.Generic;

namespace RestWithASPNet5Udemy1.Repository {
    public interface IPersonRepository {
        Person Create(Person person);

        Person FindByID(long id);

        List<Person> Findall();

        Person Update(Person person);

        void Delete(long id);

        bool Exists(long id);

    }
}
