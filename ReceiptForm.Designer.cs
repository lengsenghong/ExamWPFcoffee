namespace ExamWPFcoffee
{
    partial class ReceiptForm
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
            panel1 = new Panel();
            CoffeeShop = new Label();
            receiptTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnPrintReceipt = new Button();
            btnPageSetup = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CoffeeShop);
            panel1.Controls.Add(receiptTextBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 623);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // CoffeeShop
            // 
            CoffeeShop.AutoSize = true;
            CoffeeShop.Font = new Font("iKampuchea001_O'Chrov", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoffeeShop.Location = new Point(93, 86);
            CoffeeShop.Name = "CoffeeShop";
            CoffeeShop.Size = new Size(71, 22);
            CoffeeShop.TabIndex = 3;
            CoffeeShop.Text = "CoffeeShop";
            // 
            // receiptTextBox
            // 
            receiptTextBox.Location = new Point(14, 151);
            receiptTextBox.Multiline = true;
            receiptTextBox.Name = "receiptTextBox";
            receiptTextBox.ReadOnly = true;
            receiptTextBox.ScrollBars = ScrollBars.Vertical;
            receiptTextBox.Size = new Size(235, 316);
            receiptTextBox.TabIndex = 1;
            receiptTextBox.TextChanged += receiptTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coffee_coffee_shop_logo_template_59362_951;
            pictureBox1.Location = new Point(88, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.GreenYellow;
            btnPrintReceipt.ForeColor = SystemColors.ControlText;
            btnPrintReceipt.Location = new Point(272, 86);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(58, 34);
            btnPrintReceipt.TabIndex = 1;
            btnPrintReceipt.Text = "Print";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // btnPageSetup
            // 
            btnPageSetup.BackColor = SystemColors.MenuHighlight;
            btnPageSetup.ForeColor = Color.Cornsilk;
            btnPageSetup.Location = new Point(272, 12);
            btnPageSetup.Name = "btnPageSetup";
            btnPageSetup.Size = new Size(58, 68);
            btnPageSetup.TabIndex = 2;
            btnPageSetup.Text = "PageSetup";
            btnPageSetup.UseVisualStyleBackColor = false;
            btnPageSetup.Click += btnPageSetup_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 620);
            Controls.Add(btnPageSetup);
            Controls.Add(btnPrintReceipt);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ReceiptForm";
            Load += ReceiptForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox receiptTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnPrintReceipt;
        private Button btnPageSetup;
        private Label CoffeeShop;
    }
}