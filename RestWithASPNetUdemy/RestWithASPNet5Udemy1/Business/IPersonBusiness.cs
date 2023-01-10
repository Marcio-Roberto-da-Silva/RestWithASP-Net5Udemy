
using RestWithASPNet5Udemy1.Data.VO;
using RestWithASPNet5Udemy1.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASPNet5Udemy1.Business {
    public interface IPersonBusiness 
    {
        PersonVO Create(PersonVO person);

        PersonVO FindByID(long id);

        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> Findall();
        PagedSearchVO<PersonVO> FindWithPagedSearch(
            string name, string sortDirection, int pageSize, int page);

        PersonVO Update(PersonVO person);

        PersonVO Disable(long id);

        void Delete(long id);
    }
}
