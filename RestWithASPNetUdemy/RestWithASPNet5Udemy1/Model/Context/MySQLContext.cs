using Microsoft.EntityFrameworkCore;
using RestWithASPNet5Udemy1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNet5Udemy1.Model.Context {
    public class MySQLContext : DbContext
        {
        public MySQLContext() {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base (options) {

        }
        public  DbSet<Person> Persons { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
