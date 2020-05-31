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
    public partial class NewCustInfoForm : Form
    {
        public Customer Customer { get; set; }
        private FestivalHandler handler;
        public NewCustInfoForm()
        {
            InitializeComponent();
            handler = new FestivalHandler(Program.connectionString);
        }

        /// <summary>
        /// Validates input firstName. If unsuccessful, shows the corresponding errorLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(firstNameTextBox.Text.Length < 1)
            {
                firstNameErrorLabel.Text = "Required";
                firstNameErrorLabel.Visible = true;
                firstNameTextBox.BackColor = SystemColors.Control;
                return;
            }
            if(handler.IsValidFirstName(firstNameTextBox.Text))
            {
                firstNameErrorLabel.Visible = false;
                firstNameTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                firstNameErrorLabel.Visible = true;
                firstNameErrorLabel.Text = "Invalid First name, only letters and '-' please";
                firstNameTextBox.BackColor = SystemColors.Control;
            }
        }

        /// <summary>
        /// Validates input lastName. If unsuccessful, shows the corresponding errorLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(lastNameTextBox.Text.Length < 1)
            {
                lastNameErrorLabel.Text = "Required";
                lastNameErrorLabel.Visible = true;
                lastNameTextBox.BackColor = SystemColors.Control;
                return;
            }
            if (handler.IsValidLastName(lastNameTextBox.Text))
            {
                lastNameErrorLabel.Visible = false;
                lastNameTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                lastNameErrorLabel.Visible = true;
                lastNameErrorLabel.Text = "Invalid Last name, only letters please";
                lastNameTextBox.BackColor = SystemColors.Control;
            }
        }

        /// <summary>
        /// Validates input phoneNumber. If unsuccessful, shows the corresponding errorLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(phoneTextBox.Text.Length < 1)
            {
                phoneErrorLabel.Text = "Required";
                phoneErrorLabel.Visible = true;
                phoneTextBox.BackColor = SystemColors.Control;
                return;
            }
            if(handler.IsValidPhoneNumber(phoneTextBox.Text))
            {
                phoneErrorLabel.Visible = false;
                phoneTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                phoneErrorLabel.Visible = true;
                phoneErrorLabel.Text = "Invalid phone number, only digits and '-'.";
                phoneTextBox.BackColor = SystemColors.Control;
            }
        }

        /// <summary>
        /// Checks validity of firstName, lastName and phoneNumber. Then adds it to the customer and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if(phoneErrorLabel.Visible || lastNameErrorLabel.Visible || firstNameErrorLabel.Visible)
            {
                MessageBox.Show("Please enter correct values before submitting");
                return;
            }
            Customer.FirstName = firstNameTextBox.Text;
            Customer.LastName = lastNameTextBox.Text;
            Customer.PhoneNumber = phoneTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// If user presses cancel, canceles the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
