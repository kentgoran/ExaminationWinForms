using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FestivalHandler
    {
        public string ConnectionString { get; set; }
        Regex firstNameRegex;
        Regex lastNameRegex;
        Regex phoneNumberRegex;

        public FestivalHandler(string connectionString)
        {
            //Conn-string is passed through in order for my teacher to change it easily
            ConnectionString = connectionString;
            //Letters, both upper and lower, and '-' for doublenames
            firstNameRegex = new Regex(@"^[A-Za-zÅÄÖåäö\-]{2,18}$");
            //Letters, both upper and lower, only
            lastNameRegex = new Regex(@"^[A-Za-zÅÄÖåäö]{2,18}$");
            //8-14 digits and '-' Also needs a secondary check so there's actually a couple numbers in it
            phoneNumberRegex = new Regex(@"^([0-9\-]{10,15})$");
        }

        /// <summary>
        /// Grabs the 10 movies in the database and returns them as a list of Movie, ordered by movieID
        /// </summary>
        /// <returns></returns>
        public List<Movie> GetMovies()
        {
            List<Movie> movies;
            using(FestivalContext context = new FestivalContext(ConnectionString))
            {
                movies = (from movie in context.Movies
                          orderby movie.MovieId ascending    
                          select movie).ToList();
            }
            return movies;
        }

        /// <summary>
        /// Finds all the shows for a given movie(its movieId), and returns them as a list of shows
        /// </summary>
        /// <param name="movie">The movie whose shows are wanted</param>
        /// <returns>List of Shows corresponding to the input movie (By movieId</returns>
        public List<Show> GetShowsForMovie(Movie movie)
        {
            List<Show> shows;
            using (FestivalContext context = new FestivalContext(ConnectionString))
            {
                shows = (from show in context.Shows
                         where show.Movie.MovieId == movie.MovieId
                         orderby show.StartTime ascending
                         select show).ToList();
            }
            return shows;
        }

        /// <summary>
        /// This method returns a Dictionary of Shows and ints, where the shows are keys, and made up of all shows
        /// the given customer has booked tickets in. The integer is the value, and corresponds to the number of tickets said customer
        /// has in the given show(Key)
        /// </summary>
        /// <param name="customer">The customer to search with</param>
        /// <returns>Dictionary of Show and int</returns>
        public Dictionary<Show,int> GetCustomersShowsAndAmountOfTickets(Customer customer)
        {
            List<Ticket> tickets;
            List<Show> shows;
            using (FestivalContext context = new FestivalContext(ConnectionString))
            {
                tickets = (from tic in context.Tickets
                           where tic.CustomerId == customer.CustomerId
                           select tic).ToList();
                //fetching the shows right away as to not have to do it each time in the foreach below
                shows = context.Shows.ToList();
                //Also fetching each shows movie for showing in the frontend later
                foreach(Show show in shows)
                {
                    show.Movie = (from mov in context.Movies
                                  where mov.MovieId == show.MovieId
                                  select mov).FirstOrDefault();
                }
            }
            Dictionary<Show, int> toReturn = new Dictionary<Show, int>();
            //Goes through each ticket, if the given show is not found in the dictionary, add it
            //If the show is found, increase the ticket-number by 1
            foreach(Ticket tick in tickets)
            {
                Show actualShow = shows.Find(x => x.ShowId == tick.ShowId);
                if (toReturn.ContainsKey(actualShow))
                {
                    toReturn[actualShow]++;
                }
                else
                {
                    toReturn.Add(actualShow, 1);
                }
            }
            return toReturn;
        }

        /// <summary>
        /// Checks a string representation of a first name. if it is shorter than 2 or
        /// contains other than a-z, åäö or dash(-), it returns false
        /// </summary>
        /// <param name="fName"></param>
        /// <returns>A boolean representation of valid/invalid</returns>
        public bool IsValidFirstName(string fName)
        {
            if(fName.Length < 2)
            {
                return false;
            }
            if (firstNameRegex.IsMatch(fName))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks a string representation of a last name. if it is shorter than 2 or
        /// contains other than a-z or åäö, it returns false
        /// </summary>
        /// <param name="lName"></param>
        /// <returns>>A boolean representation of valid/invalid</returns>
        public bool IsValidLastName(string lName)
        {
            if(lName.Length < 2)
            {
                return false;
            }
            if (lastNameRegex.IsMatch(lName))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks a string representation of a ssn(swedish personnummer).
        /// If it is not in the format YYYY-MM-DD-XXXX it will return false.
        /// Checks so that it is a valid birthdate (ie date exists) and that the person is atleast 18 years old
        /// </summary>
        /// <param name="ssn"></param>
        /// <param name="errorMsg">Output string that states what is wrong with the input string.</param>
        /// <returns></returns>
        public bool IsValidSsn(string ssn, out string errorMsg)
        {
            if(ssn.Length != 15)
            {
                errorMsg = "Wrong length";
                return false;
            }
            string ssnNoLastDigits = ssn.Substring(0, 10);
            if(!DateTime.TryParse(ssnNoLastDigits, out DateTime parsedDate))
            {
                errorMsg = "Not a valid birthdate";
                return false;
            }
            DateTime minBirth = DateTime.Now.AddYears(-18);
            if(parsedDate > minBirth)
            {
                errorMsg = "You are too young.";
                return false;
            }
            string lastFour = ssn.Substring(11, 4);
            if(!int.TryParse(lastFour, out int parsedInt))
            {
                errorMsg = "invalid numbers";
                return false;
            }
            errorMsg = "Valid Ssn";
            return true;
        }

        /// <summary>
        /// Checks a string representation of a phone number.
        /// Pretty basic, doesn't check that it is a real number, only that it contains only numbers and dashes, and is between 10 and 15 digits.
        /// Also checks so that, without dashes, it is atleast 8 digits. Else it returns false
        /// </summary>
        /// <param name="phoneNum"></param>
        /// <returns>A boolean representation of valid/invalid</returns>
        public bool IsValidPhoneNumber(string phoneNum)
        {
            if(phoneNum.Length < 2)
            {
                return false;
            }
            if (phoneNumberRegex.IsMatch(phoneNum))
            {
                string withoutDash = Regex.Replace(phoneNum, @"[^0-9]", "");
                if(withoutDash.Length > 8)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Called on when a given customer wants to drop all tickets for a given show
        /// </summary>
        /// <param name="show">the show to drop tickets from</param>
        /// <param name="activeCustomer">The customer who wants to drop their tickets</param>
        /// <returns>a boolean representation of if it succeeded or not</returns>
        public bool DropTicketsForSpecificShowAndCustomer(Show show, Customer activeCustomer)
        {
            try
            {
                using (FestivalContext context = new FestivalContext(ConnectionString))
                {
                    List<Ticket> toRemove = (from ticket in context.Tickets
                                             where ticket.CustomerId == activeCustomer.CustomerId &&
                                             ticket.ShowId == show.ShowId
                                             select ticket).ToList();
                    context.Tickets.RemoveRange(toRemove);
                    context.SaveChanges();
                }
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Takes an ssn and checks if it is a current customer in the database. If it is, that customer is returned to the caller
        /// If it is not, a new Customer is created and returned (not written to the database though)
        /// A boolean is also returned, signaling if it is a new customer or not
        /// </summary>
        /// <param name="ssn">input ssn-parameter</param>
        /// <param name="isNewCustomer">boolean, signaling if it is a new customer or not</param>
        /// <returns>A customer</returns>
        public Customer GetCustomer(string ssn, out bool isNewCustomer)
        {
            Customer customer;
            using (FestivalContext context = new FestivalContext(ConnectionString))
            {
                customer = (from cust in context.Customers
                            where cust.Ssn == ssn
                            select cust).FirstOrDefault();
            }
            if(customer == null)
            {
                isNewCustomer = true;
                customer = new Customer()
                {
                    Ssn = ssn
                };
            }
            else
            {
                isNewCustomer = false;
            }
            return customer;
        }

        /// <summary>
        /// Grabs and returns all the tickets(as a list) found for a given show
        /// </summary>
        /// <param name="currentShow">the show whose tickets are going to be returned</param>
        /// <returns>A list of Ticket</returns>
        public List<Ticket> GetTicketsForShow(Show currentShow)
        {
            List<Ticket> tickets;
            using (FestivalContext context = new FestivalContext(ConnectionString))
            {
                tickets = (from ticket in context.Tickets
                           where ticket.Show.ShowId == currentShow.ShowId
                           select ticket).ToList();
            }
            return tickets;
        }

        /// <summary>
        /// For the given show, all the tickets with corresponding seatnumbers are removed
        /// </summary>
        /// <param name="show">The show where tickets are to be removed</param>
        /// <param name="seatsToRemove">a list of integers, containing the seats to remove</param>
        /// <returns>a boolean representing if it was a success or not</returns>
        public bool RemoveTickets(Show show, List<int> seatsToRemove)
        {
            bool success = true;
            using (FestivalContext context = new FestivalContext(ConnectionString))
            {
                List<Ticket> tickets = (from ticket in context.Tickets
                                        where ticket.ShowId == show.ShowId
                                        select ticket).ToList();
                //Foreach through the tickets found, and get the ones to remove. Then use those to RemoveRange in the context
                List<Ticket> ticketsToRemove = new List<Ticket>();
                foreach(int seat in seatsToRemove)
                {
                    ticketsToRemove.Add(tickets.Find(x => x.Seat == seat));
                }
                try
                {
                    context.Tickets.RemoveRange(ticketsToRemove);
                    context.SaveChanges();
                }
                catch (SqlException)
                {
                    success = false;
                }
            }
            return success;
        }

        /// <summary>
        /// Creates and saves tickets for given customer,show and seats. The seats also holds a boolean representation of if customer uses wheelchair
        /// </summary>
        /// <param name="customer">The customer who booked the tickets</param>
        /// <param name="show">The show that was booked</param>
        /// <param name="seats">The seats that are booked</param>
        /// <returns>A boolean representation if it succeeded or not</returns>
        public bool BookTickets(Customer customer, Show show, Dictionary<int,bool> seats)
        {
            bool success = true;
            customer = SaveCustomerInDB(customer);
            using (FestivalContext context = new FestivalContext(ConnectionString))
            {
                try
                {
                    foreach(var seat in seats)
                    {
                        context.Tickets.Add(new Ticket()
                        {
                            CustomerId = customer.CustomerId,

                            ShowId = show.ShowId,
                            Seat = seat.Key,
                            Wheelchair = seat.Value
                        });
                    }
                    context.SaveChanges();
                }
                catch (SqlException)
                {
                    success = false;
                }
            }
            return success;
        }

        /// <summary>
        /// If the customer is NOT found in the database, saves it (To be called on when customer wants to book tickets
        /// to ensure that the customer is added).
        /// </summary>
        /// <param name="customer">The customer to check, and add if not found</param>
        /// <returns>a Customer, if the input customer didn't have a customerId, the returned one defenitivly does</returns>
        private Customer SaveCustomerInDB(Customer customer)
        {
            Customer toReturn = customer;
            using(FestivalContext context = new FestivalContext(ConnectionString))
            {
                Customer existingCustomer = (from cust in context.Customers
                                             where cust.Ssn == customer.Ssn
                                             select cust).FirstOrDefault();
                if (existingCustomer == null)
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    //We do this as to put the customer through the database and get it's customerId
                    toReturn = (from cust in context.Customers
                                where cust.Ssn == customer.Ssn
                                select cust).FirstOrDefault();
                }
            }
            return toReturn;
            
        }
    }
}
