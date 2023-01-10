using Microsoft.EntityFrameworkCore;
using RestWithASPNet5Udemy1.Model.Base;
using RestWithASPNet5Udemy1.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNet5Udemy1.Repository.Generic {
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity {

        protected MySQLContext _context;

        private DbSet<T> dateset;
       

        public GenericRepository(MySQLContext context) {
            _context = context;
            dateset = _context.Set<T>();
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
                _context.SaveChanges();
                return item;
            } catch (Exception) {

                throw;
            }
        }
        public T Update(T item) {
            var result = dateset.SingleOrDefault(p => p.Id.Equals(item.Id));
            if (result != null) {
                try {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                } catch (Exception) {

                    throw;
                }
            } else {
                return null;
            }
        }
        public void Delete(long id) {
            var result = dateset.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null) {
                try {
                    dateset.Remove(result);
                    _context.SaveChanges();
                } catch (Exception) {

                    throw;
                }
            }
        }
        public bool Exists(long id) {
            return dateset.Any(p => p.Id.Equals(id));
        }

        public List<T> FindWithPagedSearch(string query) 
            {
            return dateset.FromSqlRaw<T>(query).ToList();
        }

        public int GetCount(string query) 
            {
            var result = "";

            using (var connection = _context.Database.GetDbConnection())  
                {
                connection.Open();
                using (var command = connection.CreateCommand()) 
                    {
                    command.CommandText = query;
                    result = command.ExecuteScalar().ToString();
                }
            }
            return int.Parse(result);
        }
    }
}       
