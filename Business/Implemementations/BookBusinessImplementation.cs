using RestWithASPNet5Udemy1.Model;
using RestWithASPNet5Udemy1.Model.Context;
using RestWithASPNet5Udemy1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithASPNet5Udemy1.Business.Implemementations {


    public class BookBusinessImplementation : IBookBusiness {
        
        //private  readonly IPersonRepository repository ;
        private IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository) {

            _repository = repository;
        }
        public List<Book> Findall() {

            return _repository.Findall();
        }

        public Book FindByID(long id) {

            return _repository.FindByID(id);
        }
        public Book Create(Book book) {

            return _repository.Create(book);
        }
        public Book Update(Book book) {

            return _repository.Update(book);
        }
        public void Delete(long id) {

            _repository.Delete(id);
        }
       
    }
}
