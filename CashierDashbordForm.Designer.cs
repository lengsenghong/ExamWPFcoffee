namespace ExamWPFcoffee
{
    partial class CashierDashbordForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashbordForm));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Ice Coffe" }, 0, SystemColors.InactiveBorder, Color.Empty, null);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "CapucinoFrappe" }, 1, SystemColors.Menu, Color.Empty, null);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Hot Capucino" }, 2, SystemColors.Menu, Color.Empty, null);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Ice Latte" }, 3, SystemColors.Menu, Color.Empty, null);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Hot Latte" }, 4, SystemColors.Menu, Color.Empty, null);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Matcha" }, 1, SystemColors.Menu, Color.Empty, null);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            imageListSmall = new ImageList(components);
            listBox1 = new ListBox();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            btnCheckout = new Button();
            btnCancelOrder = new Button();
            btnSaveOrder = new Button();
            lblTotalPrice = new Label();
            label1 = new Label();
            DataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 711);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 64, 64);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(602, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(128, 64, 64);
            listView1.BorderStyle = BorderStyle.None;
            listViewItem1.Tag = "2m";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            listView1.LargeImageList = imageListSmall;
            listView1.Location = new Point(0, 256);
            listView1.Name = "listView1";
            listView1.Size = new Size(599, 455);
            listView1.SmallImageList = imageListSmall;
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // imageListSmall
            // 
            imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
            imageListSmall.ImageStream = (ImageListStreamer)resources.GetObject("imageListSmall.ImageStream");
            imageListSmall.TransparentColor = Color.Transparent;
            imageListSmall.Images.SetKeyName(0, "9828650.png");
            imageListSmall.Images.SetKeyName(1, "9828657.png");
            imageListSmall.Images.SetKeyName(2, "11415001.png");
            imageListSmall.Images.SetKeyName(3, "11415017.png");
            imageListSmall.Images.SetKeyName(4, "11415018.png");
            imageListSmall.Images.SetKeyName(5, "green-tea-latte-frappe.jpg");
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(128, 64, 64);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ColumnWidth = 250;
            listBox1.ForeColor = SystemColors.Menu;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "Hot", "Ice", "Frappe", "Brunch", "Dinner" });
            listBox1.Location = new Point(0, 201);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(602, 60);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Location = new Point(581, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 711);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(DataGridView);
            panel3.Location = new Point(608, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(655, 711);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnCheckout);
            groupBox1.Controls.Add(btnCancelOrder);
            groupBox1.Controls.Add(btnSaveOrder);
            groupBox1.Controls.Add(lblTotalPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 510);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 201);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.LimeGreen;
            btnCheckout.ForeColor = SystemColors.ButtonFace;
            btnCheckout.Location = new Point(416, 120);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(170, 45);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.BackColor = Color.Red;
            btnCancelOrder.ForeColor = SystemColors.ButtonFace;
            btnCancelOrder.Location = new Point(153, 120);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(114, 45);
            btnCancelOrder.TabIndex = 3;
            btnCancelOrder.Text = "Cancel";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = Color.Blue;
            btnSaveOrder.ForeColor = SystemColors.ButtonFace;
            btnSaveOrder.Location = new Point(20, 120);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(114, 45);
            btnSaveOrder.TabIndex = 2;
            btnSaveOrder.Text = "Save";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(484, 46);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(53, 30);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "$7.9";
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 46);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 0;
            label1.Text = "Total";
            // 
            // DataGridView
            // 
            DataGridView.BackgroundColor = Color.FromArgb(128, 64, 64);
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Dock = DockStyle.Fill;
            DataGridView.Location = new Point(0, 0);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(655, 711);
            DataGridView.TabIndex = 1;
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            // 
            // CashierDashbordForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 711);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CashierDashbordForm";
            Text = "CashierDashbordForm";
            Load += CashierDashbordForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ListBox listBox1;
        private ListView listView1;
        private ImageList imageListSmall;
        private GroupBox groupBox1;
        private DataGridView DataGridView;
        private Button btnCheckout;
        private Button btnCancelOrder;
        private Button btnSaveOrder;
        private Label lblTotalPrice;
        private Label label1;
        private PictureBox pictureBox1;
    }
}