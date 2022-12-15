using RestWithASPNet5Udemy1.Model;
using RestWithASPNet5Udemy1.Model.Context;
using RestWithASPNet5Udemy1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithASPNet5Udemy1.Business.Implemementations {


    public class PersonBusinessImplementation : IPersonBusiness {
        
        //private  readonly IPersonRepository repository ;
        private IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository) {

            _repository = repository;
        }
        public List<Person> Findall() {

            return _repository.Findall();
        }

        public Person FindByID(long id) {

            return _repository.FindByID(id);
        }
        public Person Create(Person book) {

            return _repository.Create(book);
        }
        public Person Update(Person person) {

            return _repository.Update(person);
        }
        public void Delete(long id) {

            _repository.Delete(id);
        }
       
    }
}
