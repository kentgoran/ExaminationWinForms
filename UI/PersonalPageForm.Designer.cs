namespace UI
{
    partial class PersonalPageForm
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
            this.topLabel = new System.Windows.Forms.Label();
            this.backToMainButton = new System.Windows.Forms.Button();
            this.allMoviesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.movie1 = new System.Windows.Forms.PictureBox();
            this.movie2 = new System.Windows.Forms.PictureBox();
            this.movie3 = new System.Windows.Forms.PictureBox();
            this.movie4 = new System.Windows.Forms.PictureBox();
            this.movie5 = new System.Windows.Forms.PictureBox();
            this.movie6 = new System.Windows.Forms.PictureBox();
            this.movie7 = new System.Windows.Forms.PictureBox();
            this.movie8 = new System.Windows.Forms.PictureBox();
            this.movie9 = new System.Windows.Forms.PictureBox();
            this.movie10 = new System.Windows.Forms.PictureBox();
            this.bookLabel = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.showComboBox = new System.Windows.Forms.ComboBox();
            this.showLabel = new System.Windows.Forms.Label();
            this.dropButton = new System.Windows.Forms.Button();
            this.bookedPanel = new System.Windows.Forms.Panel();
            this.bookedMovieInfoLabel = new System.Windows.Forms.Label();
            this.bookedMovieNameLabel = new System.Windows.Forms.Label();
            this.bookedTicketLabel = new System.Windows.Forms.Label();
            this.bookedMoviePictureBox = new System.Windows.Forms.PictureBox();
            this.bookedTicketAmountBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.allMoviesLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie10)).BeginInit();
            this.bookedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookedMoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(12, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(217, 31);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Welcome XXXX";
            // 
            // backToMainButton
            // 
            this.backToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainButton.Location = new System.Drawing.Point(867, 412);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(100, 33);
            this.backToMainButton.TabIndex = 1;
            this.backToMainButton.Text = "Back to main";
            this.backToMainButton.UseVisualStyleBackColor = true;
            this.backToMainButton.Click += new System.EventHandler(this.backToMainButton_Click);
            // 
            // allMoviesLayoutPanel
            // 
            this.allMoviesLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allMoviesLayoutPanel.Controls.Add(this.movie1);
            this.allMoviesLayoutPanel.Controls.Add(this.movie2);
            this.allMoviesLayoutPanel.Controls.Add(this.movie3);
            this.allMoviesLayoutPanel.Controls.Add(this.movie4);
            this.allMoviesLayoutPanel.Controls.Add(this.movie5);
            this.allMoviesLayoutPanel.Controls.Add(this.movie6);
            this.allMoviesLayoutPanel.Controls.Add(this.movie7);
            this.allMoviesLayoutPanel.Controls.Add(this.movie8);
            this.allMoviesLayoutPanel.Controls.Add(this.movie9);
            this.allMoviesLayoutPanel.Controls.Add(this.movie10);
            this.allMoviesLayoutPanel.Location = new System.Drawing.Point(438, 96);
            this.allMoviesLayoutPanel.Name = "allMoviesLayoutPanel";
            this.allMoviesLayoutPanel.Size = new System.Drawing.Size(534, 314);
            this.allMoviesLayoutPanel.TabIndex = 2;
            // 
            // movie1
            // 
            this.movie1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie1.Location = new System.Drawing.Point(3, 3);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(100, 150);
            this.movie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie1.TabIndex = 0;
            this.movie1.TabStop = false;
            this.movie1.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie2
            // 
            this.movie2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie2.Location = new System.Drawing.Point(109, 3);
            this.movie2.Name = "movie2";
            this.movie2.Size = new System.Drawing.Size(100, 150);
            this.movie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie2.TabIndex = 1;
            this.movie2.TabStop = false;
            this.movie2.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie3
            // 
            this.movie3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie3.Location = new System.Drawing.Point(215, 3);
            this.movie3.Name = "movie3";
            this.movie3.Size = new System.Drawing.Size(100, 150);
            this.movie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie3.TabIndex = 2;
            this.movie3.TabStop = false;
            this.movie3.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie4
            // 
            this.movie4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie4.Location = new System.Drawing.Point(321, 3);
            this.movie4.Name = "movie4";
            this.movie4.Size = new System.Drawing.Size(100, 150);
            this.movie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie4.TabIndex = 3;
            this.movie4.TabStop = false;
            this.movie4.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie5
            // 
            this.movie5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie5.Location = new System.Drawing.Point(427, 3);
            this.movie5.Name = "movie5";
            this.movie5.Size = new System.Drawing.Size(100, 150);
            this.movie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie5.TabIndex = 4;
            this.movie5.TabStop = false;
            this.movie5.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie6
            // 
            this.movie6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie6.Location = new System.Drawing.Point(3, 159);
            this.movie6.Name = "movie6";
            this.movie6.Size = new System.Drawing.Size(100, 150);
            this.movie6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie6.TabIndex = 5;
            this.movie6.TabStop = false;
            this.movie6.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie7
            // 
            this.movie7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie7.Location = new System.Drawing.Point(109, 159);
            this.movie7.Name = "movie7";
            this.movie7.Size = new System.Drawing.Size(100, 150);
            this.movie7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie7.TabIndex = 6;
            this.movie7.TabStop = false;
            this.movie7.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie8
            // 
            this.movie8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie8.Location = new System.Drawing.Point(215, 159);
            this.movie8.Name = "movie8";
            this.movie8.Size = new System.Drawing.Size(100, 150);
            this.movie8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie8.TabIndex = 7;
            this.movie8.TabStop = false;
            this.movie8.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie9
            // 
            this.movie9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie9.Location = new System.Drawing.Point(321, 159);
            this.movie9.Name = "movie9";
            this.movie9.Size = new System.Drawing.Size(100, 150);
            this.movie9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie9.TabIndex = 8;
            this.movie9.TabStop = false;
            this.movie9.Click += new System.EventHandler(this.movie_Click);
            // 
            // movie10
            // 
            this.movie10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.movie10.Location = new System.Drawing.Point(427, 159);
            this.movie10.Name = "movie10";
            this.movie10.Size = new System.Drawing.Size(100, 150);
            this.movie10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movie10.TabIndex = 9;
            this.movie10.TabStop = false;
            this.movie10.Click += new System.EventHandler(this.movie_Click);
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(544, 77);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(328, 16);
            this.bookLabel.TabIndex = 3;
            this.bookLabel.Text = "In order to book a ticket, click the desired movie below";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.Location = new System.Drawing.Point(18, 77);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(283, 16);
            this.ticketLabel.TabIndex = 4;
            this.ticketLabel.Text = "Below you can see and update  your bookings";
            // 
            // showComboBox
            // 
            this.showComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showComboBox.FormattingEnabled = true;
            this.showComboBox.Location = new System.Drawing.Point(69, 15);
            this.showComboBox.Name = "showComboBox";
            this.showComboBox.Size = new System.Drawing.Size(348, 24);
            this.showComboBox.TabIndex = 5;
            this.showComboBox.SelectedIndexChanged += new System.EventHandler(this.showComboBox_SelectedIndexChanged);
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLabel.Location = new System.Drawing.Point(19, 18);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(44, 16);
            this.showLabel.TabIndex = 6;
            this.showLabel.Text = "Show:";
            // 
            // dropButton
            // 
            this.dropButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropButton.Location = new System.Drawing.Point(9, 257);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(113, 33);
            this.dropButton.TabIndex = 7;
            this.dropButton.Text = "Drop all tickets";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // bookedPanel
            // 
            this.bookedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookedPanel.Controls.Add(this.bookedMovieInfoLabel);
            this.bookedPanel.Controls.Add(this.bookedMovieNameLabel);
            this.bookedPanel.Controls.Add(this.bookedTicketLabel);
            this.bookedPanel.Controls.Add(this.bookedMoviePictureBox);
            this.bookedPanel.Controls.Add(this.bookedTicketAmountBox);
            this.bookedPanel.Controls.Add(this.changeButton);
            this.bookedPanel.Controls.Add(this.showComboBox);
            this.bookedPanel.Controls.Add(this.dropButton);
            this.bookedPanel.Controls.Add(this.showLabel);
            this.bookedPanel.Location = new System.Drawing.Point(12, 96);
            this.bookedPanel.Name = "bookedPanel";
            this.bookedPanel.Size = new System.Drawing.Size(423, 314);
            this.bookedPanel.TabIndex = 8;
            // 
            // bookedMovieInfoLabel
            // 
            this.bookedMovieInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedMovieInfoLabel.Location = new System.Drawing.Point(129, 74);
            this.bookedMovieInfoLabel.Name = "bookedMovieInfoLabel";
            this.bookedMovieInfoLabel.Size = new System.Drawing.Size(288, 121);
            this.bookedMovieInfoLabel.TabIndex = 13;
            this.bookedMovieInfoLabel.Text = "Info placeholder";
            // 
            // bookedMovieNameLabel
            // 
            this.bookedMovieNameLabel.AutoSize = true;
            this.bookedMovieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedMovieNameLabel.Location = new System.Drawing.Point(129, 46);
            this.bookedMovieNameLabel.Name = "bookedMovieNameLabel";
            this.bookedMovieNameLabel.Size = new System.Drawing.Size(124, 24);
            this.bookedMovieNameLabel.TabIndex = 12;
            this.bookedMovieNameLabel.Text = "Movie name";
            // 
            // bookedTicketLabel
            // 
            this.bookedTicketLabel.AutoSize = true;
            this.bookedTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedTicketLabel.Location = new System.Drawing.Point(22, 214);
            this.bookedTicketLabel.Name = "bookedTicketLabel";
            this.bookedTicketLabel.Size = new System.Drawing.Size(55, 16);
            this.bookedTicketLabel.TabIndex = 11;
            this.bookedTicketLabel.Text = "Tickets:";
            // 
            // bookedMoviePictureBox
            // 
            this.bookedMoviePictureBox.Location = new System.Drawing.Point(22, 45);
            this.bookedMoviePictureBox.Name = "bookedMoviePictureBox";
            this.bookedMoviePictureBox.Size = new System.Drawing.Size(100, 150);
            this.bookedMoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookedMoviePictureBox.TabIndex = 10;
            this.bookedMoviePictureBox.TabStop = false;
            // 
            // bookedTicketAmountBox
            // 
            this.bookedTicketAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedTicketAmountBox.Location = new System.Drawing.Point(83, 211);
            this.bookedTicketAmountBox.Name = "bookedTicketAmountBox";
            this.bookedTicketAmountBox.ReadOnly = true;
            this.bookedTicketAmountBox.Size = new System.Drawing.Size(39, 22);
            this.bookedTicketAmountBox.TabIndex = 9;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(128, 257);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(161, 33);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Change seats/amounts";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // PersonalPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 447);
            this.Controls.Add(this.bookedPanel);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.allMoviesLayoutPanel);
            this.Controls.Add(this.backToMainButton);
            this.Controls.Add(this.topLabel);
            this.Name = "PersonalPageForm";
            this.Text = "BookingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalPageForm_FormClosing);
            this.Shown += new System.EventHandler(this.BookingForm_Shown);
            this.EnabledChanged += new System.EventHandler(this.PersonalPageForm_EnabledChanged);
            this.allMoviesLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie10)).EndInit();
            this.bookedPanel.ResumeLayout(false);
            this.bookedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookedMoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button backToMainButton;
        private System.Windows.Forms.FlowLayoutPanel allMoviesLayoutPanel;
        private System.Windows.Forms.PictureBox movie1;
        private System.Windows.Forms.PictureBox movie2;
        private System.Windows.Forms.PictureBox movie3;
        private System.Windows.Forms.PictureBox movie4;
        private System.Windows.Forms.PictureBox movie5;
        private System.Windows.Forms.PictureBox movie6;
        private System.Windows.Forms.PictureBox movie7;
        private System.Windows.Forms.PictureBox movie8;
        private System.Windows.Forms.PictureBox movie9;
        private System.Windows.Forms.PictureBox movie10;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.ComboBox showComboBox;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Panel bookedPanel;
        private System.Windows.Forms.Label bookedMovieInfoLabel;
        private System.Windows.Forms.Label bookedMovieNameLabel;
        private System.Windows.Forms.Label bookedTicketLabel;
        private System.Windows.Forms.PictureBox bookedMoviePictureBox;
        private System.Windows.Forms.TextBox bookedTicketAmountBox;
        private System.Windows.Forms.Button changeButton;
    }
}