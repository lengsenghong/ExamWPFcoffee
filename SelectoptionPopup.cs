using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWPFcoffee
{
    public partial class SelectoptionPopup : Form
    {
        // Properties to store drink options
        public string SelectedDrink { get; private set; }
        public string SelectedSize { get; private set; } = "S"; // Default size
        public int Quantity { get; private set; } = 1; // Default quantity
        public bool AddCream { get; private set; } = false;
        public bool AddSugar { get; private set; } = false;
        public int ShotCount { get; private set; } = 0; // Default 0 shots

        private string selectedDrink;
        private decimal price;

        // Modify the constructor to accept both arguments
        public SelectoptionPopup(string selectedDrink, decimal price)
        {
            this.selectedDrink = selectedDrink;
            this.price = price;

            InitializeComponent();
        }

        public SelectoptionPopup(string selectedDrink)
        {
            InitializeComponent();
            SelectedDrink = selectedDrink;
            //lblDrinkName.Text = $"Selected Drink: {SelectedDrink}";
        }



        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            // Create an Order object to store the user's selections
            var order = new Order
            {
                Drink = SelectedDrink,
                Size = SelectedSize,
                Quantity = Quantity,
                Cream = AddCream,
                Sugar = AddSugar,
                Shots = ShotCount
            };

            // Set the Tag property to store the Order object, which will be passed back to CashierDashbordForm
            this.Tag = order;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void QuantityCup_ValueChanged(object sender, EventArgs e)
        {
            Quantity = (int)QuantityCup.Value;
        }

        private void btnSizeS_Click(object sender, EventArgs e)
        {
            SelectedSize = "S";
            UpdateSizeSelection();

        }

        private void btnSizeL_Click(object sender, EventArgs e)
        {
            SelectedSize = "L";
            UpdateSizeSelection();

        }

        private void btnSizeXL_Click(object sender, EventArgs e)
        {
            SelectedSize = "XL";
            UpdateSizeSelection();
        }

        private void SelectoptionPopup_Load(object sender, EventArgs e)
        {

        }


        private void UpdateSizeSelection()
        {
            // Highlight the selected size button
            btnSizeS.BackColor = SelectedSize == "S" ? Color.LightBlue : SystemColors.Control;
            btnSizeL.BackColor = SelectedSize == "L" ? Color.LightBlue : SystemColors.Control;
            btnSizeXL.BackColor = SelectedSize == "XL" ? Color.LightBlue : SystemColors.Control;
        }


        private void oneShot_CheckedChanged(object sender, EventArgs e)
        {
            ShotCount = 1;
        }

        private void twoShot_CheckedChanged(object sender, EventArgs e)
        {
            ShotCount = 2;
        }

        private void threeShot_CheckedChanged(object sender, EventArgs e)
        {
            ShotCount = 3;
        }

        private void AddCreamCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            AddCream = AddCreamCheckbox.Checked;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
