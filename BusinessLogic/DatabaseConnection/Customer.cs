using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace BusinessLogic
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Customer()
        {
            Tickets = new List<Ticket>();
        }
    }
}
