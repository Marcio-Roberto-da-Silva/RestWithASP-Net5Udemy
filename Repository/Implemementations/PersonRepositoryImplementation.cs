using RestWithASPNet5Udemy1.Controllers;
using RestWithASPNet5Udemy1.Model;
using RestWithASPNet5Udemy1.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithASPNet5Udemy1.Repository.Implemementations {


    public class PersonRepositoryImplementation : IPersonRepository {
        
        private  MySQLContext _Context ;

        public PersonRepositoryImplementation(MySQLContext context) {
            _Context = context;
        }
        public List<Person> Findall() {

            return _Context.Persons.ToList();
        }


        public Person FindByID(long id) {

            return _Context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }
        public Person Create(Person person) {
            try {
                _Context.Add(person);
                _Context.SaveChanges();
            } 
            catch (Exception) {

                throw;
            }

            return person;
        }
        public Person Update(Person person) {

            if (!Exists(person.Id)) return null;

            var result = _Context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
            if (result != null) {

                try {
                    _Context.Entry(result).CurrentValues.SetValues(person);
                    _Context.SaveChanges();
                } catch (Exception) {

                    throw;
                }
            }
            return person;
        }
        public void Delete(long id) {

            var result = _Context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null) {

                try {
                    _Context.Persons.Remove(result);
                    _Context.SaveChanges();
                } catch (Exception) {

                    throw;
                }
            }
        }
       public bool Exists(long id) {

            return _Context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
