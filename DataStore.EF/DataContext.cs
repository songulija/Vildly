using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.Models;

namespace DataStore.EF
{
    /// <summary>
    /// have to inherit from DbContext. This instance represents session with database and
    /// can be used to query and save instances of your entities
    /// BugsContext represents database itself
    /// </summary>
    public class DataContext : DbContext
    {
        /**
         * Create a constructor. With DbContextOptions 
         * these options can be used to configure DataContext
         * And be use base class constructor. When using DataContext class
         * we will have to provide those options to this constructor 
         * then it'll go to constructor of DbContext class
         */
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        /**
         * Each DbSet corresponds to TABLE. Project and Customer objects
         * will have their own tables
         */
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
