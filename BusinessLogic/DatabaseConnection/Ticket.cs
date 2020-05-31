using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Show Show { get; set; }
        public int ShowId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public int Seat { get; set; }
        public bool Wheelchair { get; set; }
    }
}
