namespace ExamWPFcoffee
{
    partial class SelectoptionPopup
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
            groupBox1 = new GroupBox();
            btnSizeXL = new Button();
            btnSizeL = new Button();
            btnSizeS = new Button();
            groupBox2 = new GroupBox();
            AddCreamCheckbox = new CheckBox();
            btnAddToCard = new Button();
            label3 = new Label();
            QuantityCup = new NumericUpDown();
            panel2 = new Panel();
            ZeroSuger = new RadioButton();
            label1 = new Label();
            FithtySuger = new RadioButton();
            TwentyFiveSuger = new RadioButton();
            HandredSuger = new RadioButton();
            label2 = new Label();
            threeShot = new RadioButton();
            twoShot = new RadioButton();
            oneShot = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityCup).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 64, 0);
            groupBox1.Controls.Add(btnSizeXL);
            groupBox1.Controls.Add(btnSizeL);
            groupBox1.Controls.Add(btnSizeS);
            groupBox1.ForeColor = Color.Snow;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Size";
            // 
            // btnSizeXL
            // 
            btnSizeXL.ForeColor = Color.Black;
            btnSizeXL.Location = new Point(576, 41);
            btnSizeXL.Name = "btnSizeXL";
            btnSizeXL.Size = new Size(161, 49);
            btnSizeXL.TabIndex = 2;
            btnSizeXL.Text = "XL";
            btnSizeXL.UseVisualStyleBackColor = true;
            btnSizeXL.Click += btnSizeXL_Click;
            // 
            // btnSizeL
            // 
            btnSizeL.ForeColor = Color.Black;
            btnSizeL.Location = new Point(344, 41);
            btnSizeL.Name = "btnSizeL";
            btnSizeL.Size = new Size(161, 49);
            btnSizeL.TabIndex = 1;
            btnSizeL.Text = "L";
            btnSizeL.UseVisualStyleBackColor = true;
            btnSizeL.Click += btnSizeL_Click;
            // 
            // btnSizeS
            // 
            btnSizeS.ForeColor = Color.Black;
            btnSizeS.Location = new Point(112, 41);
            btnSizeS.Name = "btnSizeS";
            btnSizeS.Size = new Size(161, 49);
            btnSizeS.TabIndex = 0;
            btnSizeS.Text = "S";
            btnSizeS.UseVisualStyleBackColor = true;
            btnSizeS.Click += btnSizeS_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 64, 0);
            groupBox2.Controls.Add(AddCreamCheckbox);
            groupBox2.Controls.Add(btnAddToCard);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(QuantityCup);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(threeShot);
            groupBox2.Controls.Add(twoShot);
            groupBox2.Controls.Add(oneShot);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(777, 317);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Option";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // AddCreamCheckbox
            // 
            AddCreamCheckbox.AutoSize = true;
            AddCreamCheckbox.Location = new Point(58, 26);
            AddCreamCheckbox.Name = "AddCreamCheckbox";
            AddCreamCheckbox.Size = new Size(100, 24);
            AddCreamCheckbox.TabIndex = 13;
            AddCreamCheckbox.Text = "AddCream";
            AddCreamCheckbox.UseVisualStyleBackColor = true;
            AddCreamCheckbox.CheckedChanged += AddCreamCheckbox_CheckedChanged;
            // 
            // btnAddToCard
            // 
            btnAddToCard.BackColor = Color.Lime;
            btnAddToCard.ForeColor = Color.Black;
            btnAddToCard.Location = new Point(565, 225);
            btnAddToCard.Name = "btnAddToCard";
            btnAddToCard.Size = new Size(172, 48);
            btnAddToCard.TabIndex = 12;
            btnAddToCard.Text = "Add To Cart";
            btnAddToCard.UseVisualStyleBackColor = false;
            btnAddToCard.Click += btnAddToCard_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 239);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 11;
            label3.Text = "Quantity     :";
            // 
            // QuantityCup
            // 
            QuantityCup.Location = new Point(182, 237);
            QuantityCup.Name = "QuantityCup";
            QuantityCup.Size = new Size(134, 27);
            QuantityCup.TabIndex = 10;
            QuantityCup.ValueChanged += QuantityCup_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(ZeroSuger);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(FithtySuger);
            panel2.Controls.Add(TwentyFiveSuger);
            panel2.Controls.Add(HandredSuger);
            panel2.Location = new Point(58, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 60);
            panel2.TabIndex = 9;
            // 
            // ZeroSuger
            // 
            ZeroSuger.AutoSize = true;
            ZeroSuger.Location = new Point(124, 18);
            ZeroSuger.Name = "ZeroSuger";
            ZeroSuger.Size = new Size(48, 24);
            ZeroSuger.TabIndex = 6;
            ZeroSuger.TabStop = true;
            ZeroSuger.Text = "0%";
            ZeroSuger.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Sugar          :";
            // 
            // FithtySuger
            // 
            FithtySuger.AutoSize = true;
            FithtySuger.Location = new Point(369, 20);
            FithtySuger.Name = "FithtySuger";
            FithtySuger.Size = new Size(56, 24);
            FithtySuger.TabIndex = 4;
            FithtySuger.TabStop = true;
            FithtySuger.Text = "50%";
            FithtySuger.UseVisualStyleBackColor = true;
            // 
            // TwentyFiveSuger
            // 
            TwentyFiveSuger.AutoSize = true;
            TwentyFiveSuger.Location = new Point(245, 20);
            TwentyFiveSuger.Name = "TwentyFiveSuger";
            TwentyFiveSuger.Size = new Size(56, 24);
            TwentyFiveSuger.TabIndex = 5;
            TwentyFiveSuger.TabStop = true;
            TwentyFiveSuger.Text = "25%";
            TwentyFiveSuger.UseVisualStyleBackColor = true;
            // 
            // HandredSuger
            // 
            HandredSuger.AutoSize = true;
            HandredSuger.Location = new Point(477, 18);
            HandredSuger.Name = "HandredSuger";
            HandredSuger.Size = new Size(62, 24);
            HandredSuger.TabIndex = 3;
            HandredSuger.TabStop = true;
            HandredSuger.Text = "100%";
            HandredSuger.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 158);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 8;
            label2.Text = "Shot          :";
            // 
            // threeShot
            // 
            threeShot.AutoSize = true;
            threeShot.Location = new Point(431, 158);
            threeShot.Name = "threeShot";
            threeShot.Size = new Size(35, 24);
            threeShot.TabIndex = 7;
            threeShot.TabStop = true;
            threeShot.Text = "3";
            threeShot.UseVisualStyleBackColor = true;
            threeShot.CheckedChanged += threeShot_CheckedChanged;
            // 
            // twoShot
            // 
            twoShot.AutoSize = true;
            twoShot.Location = new Point(308, 158);
            twoShot.Name = "twoShot";
            twoShot.Size = new Size(35, 24);
            twoShot.TabIndex = 6;
            twoShot.TabStop = true;
            twoShot.Text = "2";
            twoShot.UseVisualStyleBackColor = true;
            twoShot.CheckedChanged += twoShot_CheckedChanged;
            // 
            // oneShot
            // 
            oneShot.AutoSize = true;
            oneShot.Location = new Point(185, 158);
            oneShot.Name = "oneShot";
            oneShot.Size = new Size(33, 24);
            oneShot.TabIndex = 4;
            oneShot.TabStop = true;
            oneShot.Text = "1";
            oneShot.UseVisualStyleBackColor = true;
            oneShot.CheckedChanged += oneShot_CheckedChanged;
            // 
            // SelectoptionPopup
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 474);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "SelectoptionPopup";
            Text = "SelectoptionPopup";
            Load += SelectoptionPopup_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityCup).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSizeS;
        private Button btnSizeXL;
        private Button btnSizeL;
        private GroupBox groupBox2;
        private Label label2;
        private RadioButton threeShot;
        private RadioButton twoShot;
        private RadioButton oneShot;
        private RadioButton TwentyFiveSuger;
        private RadioButton FithtySuger;
        private RadioButton HandredSuger;
        private Label label1;
        //private CheckBox AddCream;
        private Label label3;
        private NumericUpDown QuantityCup;
        private Panel panel2;
        private Button btnAddToCard;
        private RadioButton ZeroSuger;
        private CheckBox AddCreamCheckbox;
    }
}