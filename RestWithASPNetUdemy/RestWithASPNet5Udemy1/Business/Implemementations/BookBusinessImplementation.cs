using RestWithASPNet5Udemy1.Data.Converter.Implementions;
using RestWithASPNet5Udemy1.Data.VO;
using RestWithASPNet5Udemy1.Model;
using RestWithASPNet5Udemy1.Model.Context;
using RestWithASPNet5Udemy1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithASPNet5Udemy1.Business.Implemementations {


    public class BookBusinessImplementation : IBookBusiness {
        
        //private  readonly IPersonRepository repository ;
        private IRepository<Book> _repository;
        private BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository) {

            _repository = repository;
            _converter = new BookConverter();
        }
        public List<BookVO> Findall() {

            return _converter.Parse(_repository.Findall());
        }

        public BookVO FindByID(long id) {

            return _converter.Parse(_repository.FindByID(id));
        }
        public BookVO Create(BookVO book) {

            var booknEntity = _converter.Parse(book);
            booknEntity = _repository.Create(booknEntity);
            return _converter.Parse(booknEntity);
        }

        public BookVO Update(BookVO book) {

            var personEntity = _converter.Parse(book);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        public void Delete(long id) {

            _repository.Delete(id);
        }
       
    }
}
