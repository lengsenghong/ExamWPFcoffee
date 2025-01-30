namespace ExamWPFcoffee
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            tabControl1 = new TabControl();
            StaffPage = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnExcel = new Button();
            btnAddStaff = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            lblGender = new Label();
            Admin = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Drinks = new TabPage();
            drinkDataGridView = new DataGridView();
            btnViewDrink = new Button();
            btnAddDrink = new Button();
            IcePage = new TabPage();
            FrappePage = new TabPage();
            BrunchPage = new TabPage();
            DinnerPage = new TabPage();
            SnackPage = new TabPage();
            toolStrip1 = new ToolStrip();
            label6 = new Label();
            label7 = new Label();
            clickToSeeToolStripMenuItem = new ToolStripMenuItem();
            instructionToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            StaffPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Drinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drinkDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 64, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1200, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, newToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 24);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 24);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 24);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 24);
            newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem, fontToolStripMenuItem, colorToolStripMenuItem });
            editToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(44, 23);
            editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(52, 23);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clickToSeeToolStripMenuItem, instructionToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(49, 23);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tabControl1);
            toolStripContainer1.ContentPanel.Margin = new Padding(4, 5, 4, 5);
            toolStripContainer1.ContentPanel.Size = new Size(1200, 659);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 27);
            toolStripContainer1.Margin = new Padding(4, 5, 4, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1200, 684);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(StaffPage);
            tabControl1.Controls.Add(Drinks);
            tabControl1.Controls.Add(IcePage);
            tabControl1.Controls.Add(FrappePage);
            tabControl1.Controls.Add(BrunchPage);
            tabControl1.Controls.Add(DinnerPage);
            tabControl1.Controls.Add(SnackPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1200, 659);
            tabControl1.TabIndex = 0;
            // 
            // StaffPage
            // 
            StaffPage.Controls.Add(splitContainer1);
            StaffPage.Location = new Point(4, 39);
            StaffPage.Name = "StaffPage";
            StaffPage.Size = new Size(1192, 616);
            StaffPage.TabIndex = 6;
            StaffPage.Text = "Staff";
            StaffPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1192, 616);
            splitContainer1.SplitterDistance = 586;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(580, 497);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(btnAddStaff);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 107);
            panel1.TabIndex = 2;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Teal;
            btnExcel.ForeColor = SystemColors.ButtonFace;
            btnExcel.Location = new Point(391, 18);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(159, 63);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "XLSX";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = Color.SeaGreen;
            btnAddStaff.ForeColor = SystemColors.ButtonFace;
            btnAddStaff.Location = new Point(185, 18);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(159, 63);
            btnAddStaff.TabIndex = 1;
            btnAddStaff.Text = "Add Staff";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 0;
            label1.Text = "Action : ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label7, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(lblGender, 1, 1);
            tableLayoutPanel1.Controls.Add(Admin, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Location = new Point(266, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(318, 237);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 60);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 7;
            label5.Text = "12/04/2004";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(161, 30);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(59, 30);
            lblGender.TabIndex = 5;
            lblGender.Text = "male";
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Location = new Point(161, 0);
            Admin.Name = "Admin";
            Admin.Size = new Size(54, 30);
            Admin.TabIndex = 4;
            Admin.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 2;
            label2.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 6;
            label4.Text = "Date of birth";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Drinks
            // 
            Drinks.Controls.Add(drinkDataGridView);
            Drinks.Controls.Add(btnViewDrink);
            Drinks.Controls.Add(btnAddDrink);
            Drinks.ForeColor = SystemColors.ActiveCaptionText;
            Drinks.Location = new Point(4, 39);
            Drinks.Name = "Drinks";
            Drinks.Padding = new Padding(3);
            Drinks.Size = new Size(1192, 616);
            Drinks.TabIndex = 0;
            Drinks.Text = "Drinks";
            Drinks.UseVisualStyleBackColor = true;
            // 
            // drinkDataGridView
            // 
            drinkDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drinkDataGridView.Location = new Point(690, 132);
            drinkDataGridView.Name = "drinkDataGridView";
            drinkDataGridView.Size = new Size(417, 463);
            drinkDataGridView.TabIndex = 2;
            drinkDataGridView.CellContentClick += drinkDataGridView_CellContentClick;
            // 
            // btnViewDrink
            // 
            btnViewDrink.BackColor = Color.Tomato;
            btnViewDrink.ForeColor = Color.Sienna;
            btnViewDrink.Location = new Point(922, 27);
            btnViewDrink.Name = "btnViewDrink";
            btnViewDrink.Size = new Size(185, 58);
            btnViewDrink.TabIndex = 1;
            btnViewDrink.Text = "View";
            btnViewDrink.UseVisualStyleBackColor = false;
            // 
            // btnAddDrink
            // 
            btnAddDrink.BackColor = Color.Lime;
            btnAddDrink.ForeColor = Color.White;
            btnAddDrink.Location = new Point(690, 27);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(185, 58);
            btnAddDrink.TabIndex = 0;
            btnAddDrink.Text = "AddDrink";
            btnAddDrink.UseVisualStyleBackColor = false;
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // IcePage
            // 
            IcePage.Location = new Point(4, 39);
            IcePage.Name = "IcePage";
            IcePage.Padding = new Padding(3);
            IcePage.Size = new Size(1192, 616);
            IcePage.TabIndex = 1;
            IcePage.Text = "Ice";
            IcePage.UseVisualStyleBackColor = true;
            // 
            // FrappePage
            // 
            FrappePage.Location = new Point(4, 39);
            FrappePage.Name = "FrappePage";
            FrappePage.Size = new Size(1192, 616);
            FrappePage.TabIndex = 2;
            FrappePage.Text = "Frappe";
            FrappePage.UseVisualStyleBackColor = true;
            // 
            // BrunchPage
            // 
            BrunchPage.Location = new Point(4, 39);
            BrunchPage.Name = "BrunchPage";
            BrunchPage.Size = new Size(1192, 616);
            BrunchPage.TabIndex = 3;
            BrunchPage.Text = "Brunch";
            BrunchPage.UseVisualStyleBackColor = true;
            // 
            // DinnerPage
            // 
            DinnerPage.Location = new Point(4, 39);
            DinnerPage.Name = "DinnerPage";
            DinnerPage.Size = new Size(1192, 616);
            DinnerPage.TabIndex = 4;
            DinnerPage.Text = "Dinner";
            DinnerPage.UseVisualStyleBackColor = true;
            // 
            // SnackPage
            // 
            SnackPage.Location = new Point(4, 39);
            SnackPage.Name = "SnackPage";
            SnackPage.Size = new Size(1192, 616);
            SnackPage.TabIndex = 5;
            SnackPage.Text = "Snack";
            SnackPage.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(111, 25);
            toolStrip1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 88);
            label6.Name = "label6";
            label6.Size = new Size(152, 30);
            label6.TabIndex = 8;
            label6.Text = "PhoneNumber";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 88);
            label7.Name = "label7";
            label7.Size = new Size(129, 30);
            label7.TabIndex = 9;
            label7.Text = "0882633150";
            // 
            // clickToSeeToolStripMenuItem
            // 
            clickToSeeToolStripMenuItem.Name = "clickToSeeToolStripMenuItem";
            clickToSeeToolStripMenuItem.Size = new Size(180, 24);
            clickToSeeToolStripMenuItem.Text = "Click To see";
            // 
            // instructionToolStripMenuItem
            // 
            instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            instructionToolStripMenuItem.Size = new Size(180, 24);
            instructionToolStripMenuItem.Text = "instruction";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(180, 24);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 24);
            fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 24);
            colorToolStripMenuItem.Text = "Color";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 711);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tabControl1.ResumeLayout(false);
            StaffPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Drinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drinkDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private TabControl tabControl1;
        private ToolStrip toolStrip1;
        private TabPage StaffPage;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button btnExcel;
        private Button btnAddStaff;
        private Label label1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private Label label5;
        private Label lblGender;
        private Label Admin;
        private Label label4;
        private TabPage Drinks;
        private DataGridView drinkDataGridView;
        private Button btnViewDrink;
        private Button btnAddDrink;
        private TabPage IcePage;
        private TabPage FrappePage;
        private TabPage BrunchPage;
        private TabPage DinnerPage;
        private TabPage SnackPage;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem clickToSeeToolStripMenuItem;
        private ToolStripMenuItem instructionToolStripMenuItem;
        private Label label7;
        private Label label6;
    }
}