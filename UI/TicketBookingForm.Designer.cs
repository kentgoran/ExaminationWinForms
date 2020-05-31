namespace UI
{
    partial class TicketBookingForm
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
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.moviePictureBox = new System.Windows.Forms.PictureBox();
            this.seatsPanel = new System.Windows.Forms.Panel();
            this.wheelchairCheckBox = new System.Windows.Forms.CheckBox();
            this.seat20 = new System.Windows.Forms.Label();
            this.seat19 = new System.Windows.Forms.Label();
            this.seat18 = new System.Windows.Forms.Label();
            this.seat17 = new System.Windows.Forms.Label();
            this.seat16 = new System.Windows.Forms.Label();
            this.seat15 = new System.Windows.Forms.Label();
            this.seat14 = new System.Windows.Forms.Label();
            this.seat13 = new System.Windows.Forms.Label();
            this.seat12 = new System.Windows.Forms.Label();
            this.seat11 = new System.Windows.Forms.Label();
            this.seat10 = new System.Windows.Forms.Label();
            this.seat9 = new System.Windows.Forms.Label();
            this.seat8 = new System.Windows.Forms.Label();
            this.seat7 = new System.Windows.Forms.Label();
            this.seat6 = new System.Windows.Forms.Label();
            this.seat5 = new System.Windows.Forms.Label();
            this.seat4 = new System.Windows.Forms.Label();
            this.seat3 = new System.Windows.Forms.Label();
            this.seat2 = new System.Windows.Forms.Label();
            this.seat1 = new System.Windows.Forms.Label();
            this.occupiedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.occupiedTextBox = new System.Windows.Forms.TextBox();
            this.markedTextBox = new System.Windows.Forms.TextBox();
            this.freeTextBox = new System.Windows.Forms.TextBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.wheelchairLabel = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.wheelchairTextBox = new System.Windows.Forms.TextBox();
            this.startTimeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).BeginInit();
            this.seatsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLabel.Location = new System.Drawing.Point(106, 9);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(167, 31);
            this.movieNameLabel.TabIndex = 7;
            this.movieNameLabel.Text = "MovieName";
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(109, 40);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(221, 120);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Info";
            // 
            // moviePictureBox
            // 
            this.moviePictureBox.Location = new System.Drawing.Point(5, 12);
            this.moviePictureBox.Name = "moviePictureBox";
            this.moviePictureBox.Size = new System.Drawing.Size(100, 150);
            this.moviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePictureBox.TabIndex = 9;
            this.moviePictureBox.TabStop = false;
            // 
            // seatsPanel
            // 
            this.seatsPanel.Controls.Add(this.wheelchairCheckBox);
            this.seatsPanel.Controls.Add(this.seat20);
            this.seatsPanel.Controls.Add(this.seat19);
            this.seatsPanel.Controls.Add(this.seat18);
            this.seatsPanel.Controls.Add(this.seat17);
            this.seatsPanel.Controls.Add(this.seat16);
            this.seatsPanel.Controls.Add(this.seat15);
            this.seatsPanel.Controls.Add(this.seat14);
            this.seatsPanel.Controls.Add(this.seat13);
            this.seatsPanel.Controls.Add(this.seat12);
            this.seatsPanel.Controls.Add(this.seat11);
            this.seatsPanel.Controls.Add(this.seat10);
            this.seatsPanel.Controls.Add(this.seat9);
            this.seatsPanel.Controls.Add(this.seat8);
            this.seatsPanel.Controls.Add(this.seat7);
            this.seatsPanel.Controls.Add(this.seat6);
            this.seatsPanel.Controls.Add(this.seat5);
            this.seatsPanel.Controls.Add(this.seat4);
            this.seatsPanel.Controls.Add(this.seat3);
            this.seatsPanel.Controls.Add(this.seat2);
            this.seatsPanel.Controls.Add(this.seat1);
            this.seatsPanel.Location = new System.Drawing.Point(338, 9);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Size = new System.Drawing.Size(328, 223);
            this.seatsPanel.TabIndex = 10;
            // 
            // wheelchairCheckBox
            // 
            this.wheelchairCheckBox.AutoSize = true;
            this.wheelchairCheckBox.Location = new System.Drawing.Point(129, 191);
            this.wheelchairCheckBox.Name = "wheelchairCheckBox";
            this.wheelchairCheckBox.Size = new System.Drawing.Size(195, 17);
            this.wheelchairCheckBox.TabIndex = 29;
            this.wheelchairCheckBox.Text = "check if next ticket uses wheelchair";
            this.wheelchairCheckBox.UseVisualStyleBackColor = true;
            // 
            // seat20
            // 
            this.seat20.AutoSize = true;
            this.seat20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat20.Location = new System.Drawing.Point(222, 162);
            this.seat20.Name = "seat20";
            this.seat20.Size = new System.Drawing.Size(34, 26);
            this.seat20.TabIndex = 19;
            this.seat20.Text = "20";
            this.seat20.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat19
            // 
            this.seat19.AutoSize = true;
            this.seat19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat19.Location = new System.Drawing.Point(182, 162);
            this.seat19.Name = "seat19";
            this.seat19.Size = new System.Drawing.Size(34, 26);
            this.seat19.TabIndex = 18;
            this.seat19.Text = "19";
            this.seat19.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat18
            // 
            this.seat18.AutoSize = true;
            this.seat18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat18.Location = new System.Drawing.Point(142, 162);
            this.seat18.Name = "seat18";
            this.seat18.Size = new System.Drawing.Size(34, 26);
            this.seat18.TabIndex = 17;
            this.seat18.Text = "18";
            this.seat18.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat17
            // 
            this.seat17.AutoSize = true;
            this.seat17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat17.Location = new System.Drawing.Point(102, 162);
            this.seat17.Name = "seat17";
            this.seat17.Size = new System.Drawing.Size(34, 26);
            this.seat17.TabIndex = 16;
            this.seat17.Text = "17";
            this.seat17.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat16
            // 
            this.seat16.AutoSize = true;
            this.seat16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat16.Location = new System.Drawing.Point(62, 162);
            this.seat16.Name = "seat16";
            this.seat16.Size = new System.Drawing.Size(34, 26);
            this.seat16.TabIndex = 15;
            this.seat16.Text = "16";
            this.seat16.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat15
            // 
            this.seat15.AutoSize = true;
            this.seat15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat15.Location = new System.Drawing.Point(222, 127);
            this.seat15.Name = "seat15";
            this.seat15.Size = new System.Drawing.Size(34, 26);
            this.seat15.TabIndex = 14;
            this.seat15.Text = "15";
            this.seat15.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat14
            // 
            this.seat14.AutoSize = true;
            this.seat14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat14.Location = new System.Drawing.Point(182, 127);
            this.seat14.Name = "seat14";
            this.seat14.Size = new System.Drawing.Size(34, 26);
            this.seat14.TabIndex = 13;
            this.seat14.Text = "14";
            this.seat14.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat13
            // 
            this.seat13.AutoSize = true;
            this.seat13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat13.Location = new System.Drawing.Point(142, 127);
            this.seat13.Name = "seat13";
            this.seat13.Size = new System.Drawing.Size(34, 26);
            this.seat13.TabIndex = 12;
            this.seat13.Text = "13";
            this.seat13.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat12
            // 
            this.seat12.AutoSize = true;
            this.seat12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat12.Location = new System.Drawing.Point(102, 127);
            this.seat12.Name = "seat12";
            this.seat12.Size = new System.Drawing.Size(34, 26);
            this.seat12.TabIndex = 11;
            this.seat12.Text = "12";
            this.seat12.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat11
            // 
            this.seat11.AutoSize = true;
            this.seat11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat11.Location = new System.Drawing.Point(62, 127);
            this.seat11.Name = "seat11";
            this.seat11.Size = new System.Drawing.Size(34, 26);
            this.seat11.TabIndex = 10;
            this.seat11.Text = "11";
            this.seat11.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat10
            // 
            this.seat10.AutoSize = true;
            this.seat10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat10.Location = new System.Drawing.Point(222, 93);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(34, 26);
            this.seat10.TabIndex = 9;
            this.seat10.Text = "10";
            this.seat10.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat9
            // 
            this.seat9.AutoSize = true;
            this.seat9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat9.Location = new System.Drawing.Point(182, 93);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(34, 26);
            this.seat9.TabIndex = 8;
            this.seat9.Text = "09";
            this.seat9.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat8
            // 
            this.seat8.AutoSize = true;
            this.seat8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat8.Location = new System.Drawing.Point(142, 93);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(34, 26);
            this.seat8.TabIndex = 7;
            this.seat8.Text = "08";
            this.seat8.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat7
            // 
            this.seat7.AutoSize = true;
            this.seat7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat7.Location = new System.Drawing.Point(102, 93);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(34, 26);
            this.seat7.TabIndex = 6;
            this.seat7.Text = "07";
            this.seat7.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat6
            // 
            this.seat6.AutoSize = true;
            this.seat6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat6.Location = new System.Drawing.Point(62, 93);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(34, 26);
            this.seat6.TabIndex = 5;
            this.seat6.Text = "06";
            this.seat6.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat5
            // 
            this.seat5.AutoSize = true;
            this.seat5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat5.Location = new System.Drawing.Point(222, 58);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(34, 26);
            this.seat5.TabIndex = 4;
            this.seat5.Text = "05";
            this.seat5.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat4
            // 
            this.seat4.AutoSize = true;
            this.seat4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat4.Location = new System.Drawing.Point(182, 58);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(34, 26);
            this.seat4.TabIndex = 3;
            this.seat4.Text = "04";
            this.seat4.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat3
            // 
            this.seat3.AutoSize = true;
            this.seat3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat3.Location = new System.Drawing.Point(142, 58);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(34, 26);
            this.seat3.TabIndex = 2;
            this.seat3.Text = "03";
            this.seat3.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat2
            // 
            this.seat2.AutoSize = true;
            this.seat2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat2.Location = new System.Drawing.Point(102, 58);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(34, 26);
            this.seat2.TabIndex = 1;
            this.seat2.Text = "02";
            this.seat2.Click += new System.EventHandler(this.seat_Click);
            // 
            // seat1
            // 
            this.seat1.AutoSize = true;
            this.seat1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat1.Location = new System.Drawing.Point(62, 58);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(34, 26);
            this.seat1.TabIndex = 0;
            this.seat1.Text = "01";
            this.seat1.Click += new System.EventHandler(this.seat_Click);
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.AutoSize = true;
            this.occupiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupiedLabel.Location = new System.Drawing.Point(5, 6);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(66, 16);
            this.occupiedLabel.TabIndex = 11;
            this.occupiedLabel.Text = "Occupied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Free";
            // 
            // occupiedTextBox
            // 
            this.occupiedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupiedTextBox.Location = new System.Drawing.Point(76, 3);
            this.occupiedTextBox.Name = "occupiedTextBox";
            this.occupiedTextBox.ReadOnly = true;
            this.occupiedTextBox.Size = new System.Drawing.Size(36, 22);
            this.occupiedTextBox.TabIndex = 14;
            // 
            // markedTextBox
            // 
            this.markedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markedTextBox.Location = new System.Drawing.Point(76, 29);
            this.markedTextBox.Name = "markedTextBox";
            this.markedTextBox.ReadOnly = true;
            this.markedTextBox.Size = new System.Drawing.Size(36, 22);
            this.markedTextBox.TabIndex = 15;
            // 
            // freeTextBox
            // 
            this.freeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeTextBox.Location = new System.Drawing.Point(76, 55);
            this.freeTextBox.Name = "freeTextBox";
            this.freeTextBox.ReadOnly = true;
            this.freeTextBox.Size = new System.Drawing.Size(36, 22);
            this.freeTextBox.TabIndex = 16;
            // 
            // bookButton
            // 
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Location = new System.Drawing.Point(3, 3);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(84, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.occupiedLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.freeTextBox);
            this.panel2.Controls.Add(this.occupiedTextBox);
            this.panel2.Controls.Add(this.markedTextBox);
            this.panel2.Location = new System.Drawing.Point(380, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 82);
            this.panel2.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bookButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(504, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 30);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(141, 171);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(115, 16);
            this.chooseLabel.TabIndex = 21;
            this.chooseLabel.Text = "Choose start-time:";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.Location = new System.Drawing.Point(160, 197);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(96, 16);
            this.roomLabel.TabIndex = 22;
            this.roomLabel.Text = "Room number:";
            // 
            // wheelchairLabel
            // 
            this.wheelchairLabel.AutoSize = true;
            this.wheelchairLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelchairLabel.Location = new System.Drawing.Point(105, 222);
            this.wheelchairLabel.Name = "wheelchairLabel";
            this.wheelchairLabel.Size = new System.Drawing.Size(148, 16);
            this.wheelchairLabel.TabIndex = 23;
            this.wheelchairLabel.Text = "Wheelchair accessible:";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberTextBox.Location = new System.Drawing.Point(262, 194);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.ReadOnly = true;
            this.roomNumberTextBox.Size = new System.Drawing.Size(63, 22);
            this.roomNumberTextBox.TabIndex = 26;
            // 
            // wheelchairTextBox
            // 
            this.wheelchairTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelchairTextBox.Location = new System.Drawing.Point(262, 219);
            this.wheelchairTextBox.Name = "wheelchairTextBox";
            this.wheelchairTextBox.ReadOnly = true;
            this.wheelchairTextBox.Size = new System.Drawing.Size(63, 22);
            this.wheelchairTextBox.TabIndex = 27;
            this.wheelchairTextBox.TextChanged += new System.EventHandler(this.wheelchairTextBox_TextChanged);
            // 
            // startTimeComboBox
            // 
            this.startTimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeComboBox.FormattingEnabled = true;
            this.startTimeComboBox.Location = new System.Drawing.Point(262, 164);
            this.startTimeComboBox.Name = "startTimeComboBox";
            this.startTimeComboBox.Size = new System.Drawing.Size(63, 24);
            this.startTimeComboBox.TabIndex = 1;
            this.startTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.startTimeComboBox_SelectedIndexChanged);
            // 
            // TicketBookingForm
            // 
            this.AcceptButton = this.bookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(674, 331);
            this.Controls.Add(this.startTimeComboBox);
            this.Controls.Add(this.wheelchairTextBox);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.wheelchairLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.moviePictureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.movieNameLabel);
            this.Name = "TicketBookingForm";
            this.Text = "TicketBookingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketBookingForm_FormClosing);
            this.Shown += new System.EventHandler(this.TicketBookingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).EndInit();
            this.seatsPanel.ResumeLayout(false);
            this.seatsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox moviePictureBox;
        private System.Windows.Forms.Panel seatsPanel;
        private System.Windows.Forms.Label occupiedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox occupiedTextBox;
        private System.Windows.Forms.TextBox markedTextBox;
        private System.Windows.Forms.TextBox freeTextBox;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label wheelchairLabel;
        private System.Windows.Forms.Label seat1;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox wheelchairTextBox;
        private System.Windows.Forms.Label seat20;
        private System.Windows.Forms.Label seat19;
        private System.Windows.Forms.Label seat18;
        private System.Windows.Forms.Label seat17;
        private System.Windows.Forms.Label seat16;
        private System.Windows.Forms.Label seat15;
        private System.Windows.Forms.Label seat14;
        private System.Windows.Forms.Label seat13;
        private System.Windows.Forms.Label seat12;
        private System.Windows.Forms.Label seat11;
        private System.Windows.Forms.Label seat10;
        private System.Windows.Forms.Label seat9;
        private System.Windows.Forms.Label seat8;
        private System.Windows.Forms.Label seat7;
        private System.Windows.Forms.Label seat6;
        private System.Windows.Forms.Label seat5;
        private System.Windows.Forms.Label seat4;
        private System.Windows.Forms.Label seat3;
        private System.Windows.Forms.Label seat2;
        private System.Windows.Forms.ComboBox startTimeComboBox;
        private System.Windows.Forms.CheckBox wheelchairCheckBox;
    }
}