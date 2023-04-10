namespace BookningsRegisterRestaurang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtNumOfPersons = new TextBox();
            txtLastName = new TextBox();
            txtTelNumber = new TextBox();
            txtEMail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            gridVisaBokningarOutput = new DataGridView();
            txtKundId = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVisaBokningarOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 94);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(373, 25);
            label2.Name = "label2";
            label2.Size = new Size(291, 46);
            label2.TabIndex = 0;
            label2.Text = "Slice of Spice";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 552);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.78273F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.21727F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(txtNumOfPersons, 1, 4);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtTelNumber, 1, 2);
            tableLayoutPanel1.Controls.Add(txtEMail, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 2, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 2, 2);
            tableLayoutPanel1.Controls.Add(gridVisaBokningarOutput, 1, 5);
            tableLayoutPanel1.Controls.Add(txtKundId, 1, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 6);
            tableLayoutPanel1.Location = new Point(12, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.32143F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.67857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 178F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(517, 537);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(255, 224, 192);
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(153, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(177, 25);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 216);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(125, 21);
            label3.TabIndex = 2;
            label3.Text = "Num of Persons";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumOfPersons
            // 
            txtNumOfPersons.BackColor = Color.FromArgb(255, 224, 192);
            txtNumOfPersons.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumOfPersons.Location = new Point(153, 219);
            txtNumOfPersons.Name = "txtNumOfPersons";
            txtNumOfPersons.Size = new Size(177, 25);
            txtNumOfPersons.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(255, 224, 192);
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(153, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(177, 25);
            txtLastName.TabIndex = 1;
            // 
            // txtTelNumber
            // 
            txtTelNumber.BackColor = Color.FromArgb(255, 224, 192);
            txtTelNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelNumber.Location = new Point(153, 112);
            txtTelNumber.Name = "txtTelNumber";
            txtTelNumber.Size = new Size(177, 25);
            txtTelNumber.TabIndex = 1;
            // 
            // txtEMail
            // 
            txtEMail.BackColor = Color.FromArgb(255, 224, 192);
            txtEMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEMail.Location = new Point(153, 167);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(177, 25);
            txtEMail.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 52);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(86, 21);
            label6.TabIndex = 0;
            label6.Text = "Last Name";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 109);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(55, 21);
            label7.TabIndex = 0;
            label7.Text = "E-Mail";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 164);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(96, 21);
            label8.TabIndex = 0;
            label8.Text = "Tel-Number";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(362, 55);
            button2.Name = "button2";
            button2.Size = new Size(93, 45);
            button2.TabIndex = 11;
            button2.Text = "Book Now";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(362, 3);
            button1.Name = "button1";
            button1.Size = new Size(93, 44);
            button1.TabIndex = 1;
            button1.Text = "Check Availability";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.ImageAlign = ContentAlignment.BottomCenter;
            button4.Location = new Point(362, 112);
            button4.Name = "button4";
            button4.Size = new Size(93, 46);
            button4.TabIndex = 13;
            button4.Text = "Cancel Booking";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // gridVisaBokningarOutput
            // 
            gridVisaBokningarOutput.BackgroundColor = Color.FromArgb(255, 192, 128);
            gridVisaBokningarOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVisaBokningarOutput.Location = new Point(153, 271);
            gridVisaBokningarOutput.Name = "gridVisaBokningarOutput";
            gridVisaBokningarOutput.RowTemplate.Height = 25;
            gridVisaBokningarOutput.Size = new Size(177, 151);
            gridVisaBokningarOutput.TabIndex = 4;
            // 
            // txtKundId
            // 
            txtKundId.BackColor = Color.FromArgb(255, 224, 192);
            txtKundId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtKundId.Location = new Point(153, 449);
            txtKundId.Name = "txtKundId";
            txtKundId.Size = new Size(177, 25);
            txtKundId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 446);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(70, 21);
            label4.TabIndex = 2;
            label4.Text = "Kund-ID";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(535, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(578, 552);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 644);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVisaBokningarOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtNumOfPersons;
        private Label label3;
        private TextBox txtFirstName;
        private Button button4;
        private Button button1;
        private Button button2;
        private TextBox txtLastName;
        private TextBox txtTelNumber;
        private TextBox txtEMail;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView gridVisaBokningarOutput;
        private TextBox txtKundId;
        private Label label4;
    }
}