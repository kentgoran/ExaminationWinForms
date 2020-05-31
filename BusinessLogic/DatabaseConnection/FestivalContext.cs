using System;
using System.Data.Entity;

namespace BusinessLogic
{
    public class FestivalContext : DbContext
    {
        /// <summary>
        /// Base constructor for festivalContext. If no connectionstring is input, the "ordinary" one is used
        /// </summary>
        /// <param name="connectionString"></param>
        public FestivalContext(string connectionString) : base(connectionString)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
