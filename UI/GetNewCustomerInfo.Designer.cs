namespace UI
{
    partial class NewCustInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.explainLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(26, 121);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(70, 16);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(26, 147);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(70, 16);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(1, 173);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(95, 16);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone number";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(0, 35);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(434, 25);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to Horror Movie Festival 2020!";
            // 
            // explainLabel
            // 
            this.explainLabel.AutoSize = true;
            this.explainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainLabel.Location = new System.Drawing.Point(2, 71);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Size = new System.Drawing.Size(221, 16);
            this.explainLabel.TabIndex = 4;
            this.explainLabel.Text = "Please enter your credentials below";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(102, 118);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(101, 170);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(197, 22);
            this.phoneTextBox.TabIndex = 3;
            this.phoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneTextBox_Validating);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(102, 144);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastNameTextBox_Validating);
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(304, 121);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(72, 16);
            this.firstNameErrorLabel.TabIndex = 8;
            this.firstNameErrorLabel.Text = "Required";
            this.firstNameErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(304, 147);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(72, 16);
            this.lastNameErrorLabel.TabIndex = 9;
            this.lastNameErrorLabel.Text = "Required";
            this.lastNameErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.phoneErrorLabel.Location = new System.Drawing.Point(304, 173);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(72, 16);
            this.phoneErrorLabel.TabIndex = 10;
            this.phoneErrorLabel.Text = "Required";
            this.phoneErrorLabel.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(142, 199);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(223, 199);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewCustInfoForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(437, 230);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.explainLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "NewCustInfoForm";
            this.Text = "New customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label explainLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}