namespace ExamWPFcoffee
{
    partial class PaymentPopup
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
            label2 = new Label();
            CashRecive = new NumericUpDown();
            lblCashBack = new Label();
            btnProcessPayment = new Button();
            pictureBox1 = new PictureBox();
            lblTotalAmount = new Label();
            lstOrderedItems = new ListBox();
            labelitem = new Label();
            DataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CashRecive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(39, 112);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Cash Recive     : $";
            // 
            // CashRecive
            // 
            CashRecive.Location = new Point(170, 110);
            CashRecive.Name = "CashRecive";
            CashRecive.Size = new Size(198, 27);
            CashRecive.TabIndex = 2;
            CashRecive.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblCashBack
            // 
            lblCashBack.AutoSize = true;
            lblCashBack.ForeColor = SystemColors.Control;
            lblCashBack.Location = new Point(39, 175);
            lblCashBack.Name = "lblCashBack";
            lblCashBack.Size = new Size(149, 20);
            lblCashBack.TabIndex = 3;
            lblCashBack.Text = "Cash back        : $ 2.7\r\n";
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.BackColor = Color.DodgerBlue;
            btnProcessPayment.ForeColor = SystemColors.ButtonHighlight;
            btnProcessPayment.Location = new Point(97, 257);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(187, 60);
            btnProcessPayment.TabIndex = 4;
            btnProcessPayment.Text = "Process Payment";
            btnProcessPayment.UseVisualStyleBackColor = false;
            btnProcessPayment.Click += btnProcessPayment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._3d_hand_making_cashless_payment_from_smartphone;
            pictureBox1.Location = new Point(422, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.ForeColor = SystemColors.Control;
            lblTotalAmount.Location = new Point(39, 46);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(153, 20);
            lblTotalAmount.TabIndex = 6;
            lblTotalAmount.Text = "Total Amount   : $ 2.7\r\n";
            lblTotalAmount.Click += lblTotalAmount_Click;
            // 
            // lstOrderedItems
            // 
            lstOrderedItems.ForeColor = SystemColors.InactiveBorder;
            lstOrderedItems.FormattingEnabled = true;
            lstOrderedItems.ItemHeight = 20;
            lstOrderedItems.Location = new Point(446, 352);
            lstOrderedItems.Name = "lstOrderedItems";
            lstOrderedItems.Size = new Size(143, 24);
            lstOrderedItems.TabIndex = 8;
            // 
            // labelitem
            // 
            labelitem.AutoSize = true;
            labelitem.ForeColor = SystemColors.ButtonFace;
            labelitem.Location = new Point(446, 325);
            labelitem.Name = "labelitem";
            labelitem.Size = new Size(35, 20);
            labelitem.TabIndex = 9;
            labelitem.Text = "List ";
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToOrderColumns = true;
            DataGridView.BackgroundColor = Color.FromArgb(128, 64, 64);
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(747, 46);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(240, 271);
            DataGridView.TabIndex = 10;
            // 
            // PaymentPopup
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(731, 474);
            Controls.Add(DataGridView);
            Controls.Add(labelitem);
            Controls.Add(lstOrderedItems);
            Controls.Add(lblTotalAmount);
            Controls.Add(pictureBox1);
            Controls.Add(btnProcessPayment);
            Controls.Add(lblCashBack);
            Controls.Add(CashRecive);
            Controls.Add(label2);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "PaymentPopup";
            Text = "PaymentPopup";
            Load += PaymentPopup_Load;
            ((System.ComponentModel.ISupportInitialize)CashRecive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TotalAmount;
        private Label label2;
        private NumericUpDown CashRecive;
        private Label lblCashBack;
        private Button btnProcessPayment;
        private PictureBox pictureBox1;
        private Label lblTotalAmount;
        private ListBox lstOrderedItems;
        private Label labelitem;
        private DataGridView DataGridView;
    }
}