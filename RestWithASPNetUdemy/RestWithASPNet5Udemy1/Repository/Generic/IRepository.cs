using RestWithASPNet5Udemy1.Controllers;
using RestWithASPNet5Udemy1.Model;
using RestWithASPNet5Udemy1.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNet5Udemy1.Repository {
    public interface IRepository <T> where T : BaseEntity
        {
        T Create(T item);

        T FindByID(long id);

        List<T> Findall();

        T Update(T item);

        void Delete(long id);

        bool Exists(long id);

        List<T> FindWithPagedSearch(string query);
        int GetCount(string query);

    }
}
