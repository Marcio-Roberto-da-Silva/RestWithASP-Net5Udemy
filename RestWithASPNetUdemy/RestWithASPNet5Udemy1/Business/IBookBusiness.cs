using RestWithASPNet5Udemy1.Data.VO;
using RestWithASPNet5Udemy1.Model;
using System.Collections.Generic;

namespace RestWithASPNet5Udemy1.Business {
    public interface IBookBusiness 
    {
        BookVO Create(BookVO book);

        BookVO FindByID(long id);

        List<BookVO> Findall();

        BookVO Update(BookVO book);

        void Delete(long id);
       
    }
}
