using RestWithASPNet5Udemy1.Controllers;
using RestWithASPNet5Udemy1.Model;
using RestWithASPNet5Udemy1.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithASPNet5Udemy1.Repository.Implemementations {


    public class BookRepositoryImplementation : IBookRepository {
        
        private  MySQLContext _Context ;

        public BookRepositoryImplementation(MySQLContext context) {
            _Context = context;
        }
        public List<Book> Findall() {

            return _Context.Books.ToList();
        }


        public Book FindByID(long id) {

            return _Context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }
        public Book Create(Book book) {
            try {
                _Context.Add(book);
                _Context.SaveChanges();
            } 
            catch (Exception) {

                throw;
            }

            return book;
        }
        public Book Update(Book book) {

            if (!Exists(book.Id)) return null;

            var result = _Context.Persons.SingleOrDefault(p => p.Id.Equals(book.Id));
            if (result != null) {

                try {
                    _Context.Entry(result).CurrentValues.SetValues(book);
                    _Context.SaveChanges();
                } catch (Exception) {

                    throw;
                }
            }
            return book;
        }
        public void Delete(long id) {

            var result = _Context.Books.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null) {

                try {
                    _Context.Books.Remove(result);
                    _Context.SaveChanges();
                } catch (Exception) {

                    throw;
                }
            }
        }
       public bool Exists(long id) {

            return _Context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
