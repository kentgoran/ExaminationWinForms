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
    public partial class TicketBookingForm : Form
    {
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public PersonalPageForm ReturnForm { get; set; }
        public int CurrentStartTimeIndex { get; set; }

        private FestivalHandler handler;
        private List<Label> seats;
        private List<int> seatsToRemove;
        private Dictionary<int, bool> seatsToAdd;
        
        private List<Show> shows;

        public TicketBookingForm()
        {
            InitializeComponent();
            handler = new FestivalHandler(Program.connectionString);
            //Using a list of seats instead of Panel.Controls, as to not have to cast each seat from control to label, every time
            seats = new List<Label>()
            {
                seat1, seat2, seat3, seat4, seat5,
                seat6, seat7, seat8, seat9, seat10,
                seat11, seat12, seat13, seat14, seat15,
                seat16, seat17, seat18, seat19, seat20
            };
            seatsToRemove = new List<int>();
            seatsToAdd = new Dictionary<int,bool>();
            CurrentStartTimeIndex = 0;
        }

        /// <summary>
        /// Called on when cancel-button is pressed. Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Initializes stuff. Used instead of the constructor, as to be able to set which movie is clicked on etc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicketBookingForm_Shown(object sender, EventArgs e)
        {
            movieNameLabel.Text = Movie.Name;
            moviePictureBox.Image = Image.FromFile(Movie.PicturePath);
            infoLabel.Text = Movie.Info;
            shows = handler.GetShowsForMovie(Movie);
            startTimeComboBox.Items.AddRange(new string[] { "20:00", "22:00", "00:00", "02:00" });
            startTimeComboBox.SelectedIndex = CurrentStartTimeIndex;
            roomNumberTextBox.Text = shows[0].RoomNumber.ToString();
            wheelchairTextBox.Text = shows[0].GotWheelchairRamp ? "Yes" : "No";
            this.Text = $"{Movie.Name} ticket booker";
            PopulateSeats();
            
        }

        /// <summary>
        /// Called on when form is closing. Enables it's returnform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicketBookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Enabled = true;
        }

        /// <summary>
        /// Prints the current seating for the show which is chosen at the moment
        /// </summary>
        private void PopulateSeats()
        {
            Show currentShow = shows[startTimeComboBox.SelectedIndex];
            List<Ticket> ticketsForShow = handler.GetTicketsForShow(currentShow);
            seatsToAdd.Clear();
            seatsToRemove.Clear();
            foreach(Label seat in seats)
            {
                seat.BackColor = Color.Green;
            }
            foreach(Ticket ticket in ticketsForShow)
            {
                //SeatNum is -1 because list is 0-based, and the seats aren't
                int seatNum = ticket.Seat - 1;
                //if current customer holds the ticket for the given seat, set it to yellow
                if(ticket.CustomerId == Customer.CustomerId)
                {
                    seats[seatNum].BackColor = Color.Yellow;
                }
                else
                {
                    seats[seatNum].BackColor = Color.Red;
                }
            }
            UpdateOccupiedNumbers();
        }

        /// <summary>
        /// Called on when startTimeComboBox changes index, ie a new show is chosen, changes seats etc, after prompting user about possible unsaved booking-changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(seatsToAdd.Count != 0 || seatsToRemove.Count != 0)
            {
                DialogResult answer = MessageBox.Show("You have unsaved booking-changes. Discard these?", "Discard changes?", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    startTimeComboBox.SelectedIndex = CurrentStartTimeIndex;
                    return;
                }
            }
            PopulateSeats();
            CurrentStartTimeIndex = startTimeComboBox.SelectedIndex;
        }

        /// <summary>
        /// Called on when a seat is clicked. Changes it from green or yellow to the other, if it's not red.
        /// Also saves the seatnumber, or removes it, depending on the change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seat_Click(object sender, EventArgs e)
        {
            Label seat = sender as Label;
            int seatNum = int.Parse(seat.Text);
            //If red, it's already occupied. Do nothing
            if (seat.BackColor == Color.Red)
            {
                return;
            }
            //If it's yellow, it's currently booked by the current customer
            //Make it green, and remove it from the customer
            else if(seat.BackColor == Color.Yellow)
            {
                seat.BackColor = Color.Green;

                if (seatsToAdd.ContainsKey(seatNum))
                {
                    seatsToAdd.Remove(seatNum);
                }
                else
                {
                    seatsToRemove.Add(seatNum);
                }
            }
            //If this hits, the backColor is green. This is free to take,
            //Make it yellow and add it to the customers tickets
            else
            {
                seat.BackColor = Color.Yellow;
                if (seatsToRemove.Contains(seatNum))
                {
                    seatsToRemove.Remove(seatNum);
                }
                else
                {
                    seatsToAdd.Add(seatNum, wheelchairCheckBox.Checked);
                }
            }
            wheelchairCheckBox.Checked = false;
            UpdateOccupiedNumbers();
        }

        /// <summary>
        /// Starts the booking of selected seats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookButton_Click(object sender, EventArgs e)
        {
            if(seatsToAdd.Count == 0 && seatsToRemove.Count == 0)
            {
                MessageBox.Show("No changes has been made.");
                return;
            }

            if(seatsToRemove.Count > 0)
            {
                bool success = handler.RemoveTickets(shows[startTimeComboBox.SelectedIndex], seatsToRemove);
                if (success)
                {
                    MessageBox.Show($"Removed the booking of {seatsToRemove.Count} tickets.");
                    seatsToRemove.Clear();
                }
                else
                {
                    MessageBox.Show($"Attempted to remove {seatsToRemove.Count} tickets, but failed somehow.");
                }
            }
            if(seatsToAdd.Count > 0)
            {
                bool success = handler.BookTickets(Customer, shows[startTimeComboBox.SelectedIndex], seatsToAdd);
                if (success)
                {
                    MessageBox.Show($"You booked {seatsToAdd.Count} new tickets!");
                    seatsToAdd.Clear();
                }
                else
                {
                    MessageBox.Show($"Attempted to book {seatsToRemove.Count} tickets, but failed somehow.");
                }
            }
            
        }

        /// <summary>
        /// Alters the wheelchair accessability depending on the text in the wheelchair textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wheelchairTextBox_TextChanged(object sender, EventArgs e)
        {
            if(wheelchairTextBox.Text == "Yes")
            {
                wheelchairCheckBox.Visible = true;
                wheelchairCheckBox.Checked = false;
            }
            else
            {
                wheelchairCheckBox.Visible = false;
                wheelchairCheckBox.Checked = false;
            }
        }

        /// <summary>
        /// Updates the numbers displayed next to the seats, 
        /// </summary>
        private void UpdateOccupiedNumbers()
        {
            int freeSpots = 0;
            int markedSpots = 0;
            int occupiedSpots = 0;
            foreach(Label seat in seats)
            {
                if(seat.BackColor == Color.Green)
                {
                    freeSpots++;
                }
                else if(seat.BackColor == Color.Yellow)
                {
                    markedSpots++;
                }
                else
                {
                    occupiedSpots++;
                }
            }
            freeTextBox.Text = freeSpots.ToString();
            markedTextBox.Text = markedSpots.ToString();
            occupiedTextBox.Text = occupiedSpots.ToString();
        }
    }
}
