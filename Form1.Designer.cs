namespace HotelReservationUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtGuestName = new TextBox();
            cmbRoomType = new ComboBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            btnBook = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(119, 77);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(234, 23);
            txtGuestName.TabIndex = 0;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(119, 115);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(234, 23);
            cmbRoomType.TabIndex = 1;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(119, 151);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(234, 23);
            dtpCheckIn.TabIndex = 2;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(119, 180);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(234, 23);
            dtpCheckOut.TabIndex = 3;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(326, 309);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(125, 23);
            btnBook.TabIndex = 4;
            btnBook.Text = "Reserve Room";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(459, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 142);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 80);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 6;
            label1.Text = "Guest Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 115);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Room Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 157);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "CheckIn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 180);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "CheckOut";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBook);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(cmbRoomType);
            Controls.Add(txtGuestName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGuestName;
        private ComboBox cmbRoomType;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Button btnBook;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
