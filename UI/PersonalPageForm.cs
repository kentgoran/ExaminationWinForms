using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PersonalPageForm : Form
    {
        public Customer ActiveCustomer { get; set; }
        public MainForm MainForm;
        List<PictureBox> moviePictures;
        List<Movie> movies;
        List<Show> shows;
        FestivalHandler handler = new FestivalHandler(Program.connectionString);
        Dictionary<Show, int> showsAndTickets;
        public PersonalPageForm()
        {
            InitializeComponent();
            moviePictures = new List<PictureBox>()
            {
                movie1,
                movie2,
                movie3,
                movie4,
                movie5,
                movie6,
                movie7,
                movie8,
                movie9,
                movie10
            };
            showsAndTickets = new Dictionary<Show, int>();
            shows = new List<Show>();
        }
        /// <summary>
        /// Initialize the form, done here instead of constructor as to allow the form to be filled with which customer is chosen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookingForm_Shown(object sender, EventArgs e)
        {
            topLabel.Text = $"Welcome, {ActiveCustomer.FirstName}!";
            movies = handler.GetMovies();
            int picBoxIndex = 0;
            foreach (Movie movie in movies)
            {
                moviePictures[picBoxIndex].Image = Image.FromFile(movie.PicturePath);
                moviePictures[picBoxIndex].Name = movie.Name;
                picBoxIndex++;
            }
            this.Text = $"{ActiveCustomer.FirstName}'s personal page";
            PopulateBookedTickets();
        }

        /// <summary>
        /// Gets and shows all of the customers booked shows. or disables the panel if customer has none
        /// </summary>
        private void PopulateBookedTickets()
        {
            showsAndTickets = handler.GetCustomersShowsAndAmountOfTickets(ActiveCustomer);
            if (showsAndTickets.Count == 0)
            {
                bookedPanel.Enabled = false;
            }
            else
            {
                bookedPanel.Enabled = true;
                shows.Clear();
                foreach (var kvp in showsAndTickets)
                {
                    shows.Add(kvp.Key);
                }
                shows = (from s in shows
                         orderby s.ShowId ascending
                         select s).ToList();
                showComboBox.DataSource = shows;
                showComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Returns user to the main form, when clicking on Back To Main-button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When user clicks on one of the movie-posters, this method is called, which sends the user to a new form, where
        /// he or she can choose to book tickets for the given movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movie_Click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            string chosenMovie = picBox.Name;
            TicketBookingForm ticketBookingForm = new TicketBookingForm();
            ticketBookingForm.Customer = ActiveCustomer;
            ticketBookingForm.ReturnForm = this;
            ticketBookingForm.Movie = (from movie in movies
                                       where movie.Name == chosenMovie
                                       select movie).FirstOrDefault();
            ticketBookingForm.Show();
            this.Enabled = false;
        }

        /// <summary>
        /// Drops all tickets for the given show (that the user owns), when user clicks the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropButton_Click(object sender, EventArgs e)
        {
            bool success = handler.DropTicketsForSpecificShowAndCustomer(shows[showComboBox.SelectedIndex], ActiveCustomer);
            if (success)
            {
                MessageBox.Show($"Successfully removed {bookedTicketAmountBox.Text} tickets for Movie {bookedMovieNameLabel.Text}.");
                PopulateBookedTickets();
            }
            else
            {
                MessageBox.Show("Somehow the tickets couldn't be dropped. Try again later or try manually.");
            }
        }

        /// <summary>
        /// Takes the user to the ticketBookingform, and allows him/her to alter the booked tickets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeButton_Click(object sender, EventArgs e)
        {
            TicketBookingForm ticketBookingForm = new TicketBookingForm();
            ticketBookingForm.Customer = ActiveCustomer;
            ticketBookingForm.ReturnForm = this;
            ticketBookingForm.Movie = shows[showComboBox.SelectedIndex].Movie;
            //This checks startTime for the given show, and sets index in the ticketBookingForm to the right show
            if(shows[showComboBox.SelectedIndex].StartTime.Hour == 20)
            {
                ticketBookingForm.CurrentStartTimeIndex = 0;
            }
            else if(shows[showComboBox.SelectedIndex].StartTime.Hour == 22)
            {
                ticketBookingForm.CurrentStartTimeIndex = 1;
            }
            else if(shows[showComboBox.SelectedIndex].StartTime.Hour == 0)
            {
                ticketBookingForm.CurrentStartTimeIndex = 2;
            }
            else
            {
                ticketBookingForm.CurrentStartTimeIndex = 3;
            }
            ticketBookingForm.Show();
            this.Enabled = false;
        }

        /// <summary>
        /// Changes the info shown when user changes index on the showComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show currentShow = showComboBox.SelectedItem as Show;
            bookedMovieNameLabel.Text = currentShow.Movie.Name;
            bookedMovieInfoLabel.Text = currentShow.Movie.Info;
            bookedMoviePictureBox.Image = Image.FromFile(currentShow.Movie.PicturePath);
            bookedTicketAmountBox.Text = showsAndTickets[currentShow].ToString();

        }

        /// <summary>
        /// Enables the mainform, when this form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonalPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Enabled = true;
        }

        /// <summary>
        /// This method is called when user didn't have any booked shows, but then books a show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonalPageForm_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                PopulateBookedTickets();
            }
        }
    }
}
