namespace ExamWPFcoffee
{
    partial class RegisterForm
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            Genderbox = new ComboBox();
            btnRegisterForm = new Button();
            label7 = new Label();
            Role = new ComboBox();
            DateOfBirth = new MonthCalendar();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            txtPasswordRegis = new TextBox();
            txtUsernameRegis = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._307ce493_b254_4b2d_8ba4_d12c080d66511;
            pictureBox1.Location = new Point(60, 14);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 43);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 133);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Genderbox);
            groupBox1.Controls.Add(btnRegisterForm);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Role);
            groupBox1.Controls.Add(DateOfBirth);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPasswordRegis);
            groupBox1.Controls.Add(txtUsernameRegis);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(60, 199);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(338, 772);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // Genderbox
            // 
            Genderbox.FormattingEnabled = true;
            Genderbox.Items.AddRange(new object[] { "Male", "Female" });
            Genderbox.Location = new Point(23, 262);
            Genderbox.Name = "Genderbox";
            Genderbox.Size = new Size(285, 33);
            Genderbox.TabIndex = 15;
            Genderbox.SelectedIndexChanged += Genderbox_SelectedIndexChanged;
            // 
            // btnRegisterForm
            // 
            btnRegisterForm.BackColor = Color.LimeGreen;
            btnRegisterForm.ForeColor = SystemColors.ButtonFace;
            btnRegisterForm.Location = new Point(32, 712);
            btnRegisterForm.Name = "btnRegisterForm";
            btnRegisterForm.Size = new Size(285, 48);
            btnRegisterForm.TabIndex = 14;
            btnRegisterForm.Text = "Register";
            btnRegisterForm.UseVisualStyleBackColor = false;
            btnRegisterForm.Click += btnRegisterForm_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 622);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 13;
            label7.Text = "Role";
            // 
            // Role
            // 
            Role.FormattingEnabled = true;
            Role.Items.AddRange(new object[] { "Admin", "Cashier", "Staff" });
            Role.Location = new Point(32, 663);
            Role.Name = "Role";
            Role.Size = new Size(285, 33);
            Role.TabIndex = 12;
            Role.SelectedIndexChanged += Role_SelectedIndexChanged;
            // 
            // DateOfBirth
            // 
            DateOfBirth.Location = new Point(30, 444);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.TabIndex = 11;
            DateOfBirth.DateChanged += DateOfBirth_DateChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 403);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(23, 354);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(294, 33);
            txtPhoneNumber.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 313);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 8;
            label5.Text = "Phone Number";
            // 
            // txtPasswordRegis
            // 
            txtPasswordRegis.Location = new Point(23, 174);
            txtPasswordRegis.Name = "txtPasswordRegis";
            txtPasswordRegis.Size = new Size(294, 33);
            txtPasswordRegis.TabIndex = 6;
            txtPasswordRegis.TextChanged += txtPasswordRegis_TextChanged;
            // 
            // txtUsernameRegis
            // 
            txtUsernameRegis.Location = new Point(23, 84);
            txtUsernameRegis.Name = "txtUsernameRegis";
            txtUsernameRegis.Size = new Size(294, 33);
            txtUsernameRegis.TabIndex = 5;
            txtUsernameRegis.TextChanged += txtUsernameRegis_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 223);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 982);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private VScrollBar vScrollBar1;
        private MonthCalendar DateOfBirth;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtPasswordRegis;
        private TextBox txtUsernameRegis;
        private Button btnRegisterForm;
        private Label label7;
        private ComboBox Role;
        private ComboBox Genderbox;
    }
}