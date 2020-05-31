using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private FestivalHandler handler;
        private Random rnd;
        private Image mainImage;
        private Image darkerImage;
        public MainForm()
        {
            mainImage = Image.FromFile("..\\..\\..\\Resources\\Horror movie festival.jpg");
            darkerImage = Image.FromFile("..\\..\\..\\Resources\\Horror movie festival darker.jpg");
            rnd = new Random();
            InitializeComponent();
            handler = new FestivalHandler(Program.connectionString);
            horrorFestivalPictureBox.Image = mainImage;
            flickerTimer.Start();
        }

        /// <summary>
        /// Validates Ssn. If it's not valid, it shows an error message in the ssnErrorLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ssnTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(ssnTextBox.Text.Length < 1)
            {
                ssnErrorLabel.Text = "Required";
                ssnErrorLabel.Visible = true;
                ssnTextBox.BackColor = SystemColors.Control;
            }
            if (handler.IsValidSsn(ssnTextBox.Text, out string errorMsg))
            {
                ssnErrorLabel.Visible = false;
                ssnTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                ssnErrorLabel.Visible = true;
                ssnErrorLabel.Text = errorMsg;
                ssnTextBox.BackColor = SystemColors.Control;
            }

        }

        /// <summary>
        /// Method to be triggered when user clicks the submit-button. Checks if ssn is validated, then calls the backend to see if
        /// the ssn exists in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitSsnButton_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (ssnErrorLabel.Visible)
            {
                MessageBox.Show("Please enter a legit birthdate first.");
                return;
            }
            Customer activeCustomer = handler.GetCustomer(ssnTextBox.Text, out bool isNewCustomer);
            if (isNewCustomer)
            {
                DialogResult answer = MessageBox.Show("Oh, you are a new customer?\n" +
                                                      "If you press no, you will be returned to the main screen.", 
                                                      "Welcome", MessageBoxButtons.YesNo);
                if(answer == DialogResult.No)
                {
                    return;
                }
                this.Enabled = false;
                NewCustInfoForm newCustomerInfo = new NewCustInfoForm();
                newCustomerInfo.Customer = activeCustomer;
                newCustomerInfo.StartPosition = FormStartPosition.CenterParent;
                if(newCustomerInfo.ShowDialog() == DialogResult.OK)
                {
                    activeCustomer = newCustomerInfo.Customer;
                    this.Enabled = true;
                }
                else
                {
                    this.Enabled = true;
                    return;
                }
            }
            //Setup and enter the booking-form, with the active customers information
            PersonalPageForm bookingForm = new PersonalPageForm();
            bookingForm.ActiveCustomer = activeCustomer;
            bookingForm.Show();
            this.Enabled = false;
            //Set "MainForm" to this in order to be able to go back to this form if needed later on
            bookingForm.MainForm = this;
        }

        /// <summary>
        /// This makes the image "flicker" in a scary manner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flickerTimer_Tick(object sender, EventArgs e)
        {
            horrorFestivalPictureBox.Image = darkerImage;
            Application.DoEvents();
            Thread.Sleep(rnd.Next(150));
            horrorFestivalPictureBox.Image = mainImage;
        }
    }
}
