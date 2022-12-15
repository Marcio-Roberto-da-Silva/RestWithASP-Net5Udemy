using RestWithASPNet5Udemy1.Model;
using System.Collections.Generic;

namespace RestWithASPNet5Udemy1.Business {
    public interface IBookBusiness 
    {
        Book Create(Book book);

        Book FindByID(long id);

        List<Book> Findall();

        Book Update(Book book);

        void Delete(long id);

    }
}
