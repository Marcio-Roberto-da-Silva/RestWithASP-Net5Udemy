using Microsoft.EntityFrameworkCore;
using RestWithASPNet5Udemy1.Model.Base;
using RestWithASPNet5Udemy1.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNet5Udemy1.Repository.Generic {
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity {

        private MySQLContext _Context;

        private DbSet<T> dateset;
        public GenericRepository(MySQLContext context) {
            _Context = context;
            dateset = _Context.Set<T>();
        }
     
        public List<T> Findall() {
            return dateset.ToList();
        }

        public T FindByID(long id) {
            return dateset.SingleOrDefault(p => p.Id.Equals(id));
        }
        public T Create(T item) {
            try {
                dateset.Add(item);
                _Context.SaveChanges();
                return item;
            } catch (Exception) {

                throw;
            }
        }
            public T Update(T item) {
            var result = dateset.SingleOrDefault(p => p.Id.Equals(item.Id));
            if (result != null) {
                try {
                    _Context.Entry(result).CurrentValues.SetValues(item);
                    _Context.SaveChanges();
                    return result;
                }
                catch (Exception) {

                    throw;
                }   
            }
            else {
                return null;
            }
        }
        public void Delete(long id) {
            var result = dateset.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null) {
                try {
                    dateset.Remove(result);
                    _Context.SaveChanges();
                } catch (Exception) {

                    throw;
                }
            }
        }
        public bool Exists(long id) {
            return dateset.Any(p => p.Id.Equals(id));
        }
    }
}
