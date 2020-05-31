namespace UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.horrorMovieFestivalLabel = new System.Windows.Forms.Label();
            this.horrorFestivalPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitSsnButton = new System.Windows.Forms.Button();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ssnErrorLabel = new System.Windows.Forms.Label();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.flickerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.horrorFestivalPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // horrorMovieFestivalLabel
            // 
            this.horrorMovieFestivalLabel.AutoSize = true;
            this.horrorMovieFestivalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horrorMovieFestivalLabel.Location = new System.Drawing.Point(92, 4);
            this.horrorMovieFestivalLabel.Name = "horrorMovieFestivalLabel";
            this.horrorMovieFestivalLabel.Size = new System.Drawing.Size(365, 31);
            this.horrorMovieFestivalLabel.TabIndex = 0;
            this.horrorMovieFestivalLabel.Text = "Horror Movie Festival 2020";
            // 
            // horrorFestivalPictureBox
            // 
            this.horrorFestivalPictureBox.Location = new System.Drawing.Point(55, 38);
            this.horrorFestivalPictureBox.Name = "horrorFestivalPictureBox";
            this.horrorFestivalPictureBox.Size = new System.Drawing.Size(444, 277);
            this.horrorFestivalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horrorFestivalPictureBox.TabIndex = 1;
            this.horrorFestivalPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.horrorFestivalPictureBox);
            this.panel1.Controls.Add(this.horrorMovieFestivalLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 315);
            this.panel1.TabIndex = 2;
            // 
            // submitSsnButton
            // 
            this.submitSsnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitSsnButton.Location = new System.Drawing.Point(247, 403);
            this.submitSsnButton.Name = "submitSsnButton";
            this.submitSsnButton.Size = new System.Drawing.Size(82, 23);
            this.submitSsnButton.TabIndex = 2;
            this.submitSsnButton.Text = "Go!";
            this.submitSsnButton.UseVisualStyleBackColor = true;
            this.submitSsnButton.Click += new System.EventHandler(this.submitSsnButton_Click);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnTextBox.Location = new System.Drawing.Point(170, 375);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(159, 22);
            this.ssnTextBox.TabIndex = 1;
            this.ssnTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ssnTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please enter your full birthdate (YYYY-MM-DD-XXXX)";
            // 
            // ssnErrorLabel
            // 
            this.ssnErrorLabel.AutoSize = true;
            this.ssnErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ssnErrorLabel.Location = new System.Drawing.Point(335, 378);
            this.ssnErrorLabel.Name = "ssnErrorLabel";
            this.ssnErrorLabel.Size = new System.Drawing.Size(72, 16);
            this.ssnErrorLabel.TabIndex = 6;
            this.ssnErrorLabel.Text = "Required";
            this.ssnErrorLabel.Visible = false;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(BusinessLogic.Movie);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "© 2020, Simon Westman";
            // 
            // flickerTimer
            // 
            this.flickerTimer.Interval = 800;
            this.flickerTimer.Tick += new System.EventHandler(this.flickerTimer_Tick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.submitSsnButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssnErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.submitSsnButton);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Horror Movie Festival 2020";
            ((System.ComponentModel.ISupportInitialize)(this.horrorFestivalPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.Label horrorMovieFestivalLabel;
        private System.Windows.Forms.PictureBox horrorFestivalPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submitSsnButton;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ssnErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer flickerTimer;
    }
}

