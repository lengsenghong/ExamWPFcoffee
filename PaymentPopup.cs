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
    public partial class PaymentPopup : Form
    {
        // Property for the total amount passed from the dashboard
        public decimal TotalPrice { get; set; }
        public List<string> OrderedItems { get; set; }  // This will hold the ordered items passed from the parent form


        public PaymentPopup(decimal totalPrice, List<string> orderedItems)
        {
            InitializeComponent();
            TotalPrice = totalPrice;
            OrderedItems = orderedItems;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            // Get cash received from the numeric up/down control
            decimal cashReceived = CashRecive.Value;

            // Validate the payment
            if (cashReceived < TotalPrice)
            {
                MessageBox.Show("Insufficient payment. Please provide enough cash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate change
            decimal change = cashReceived - TotalPrice;

            // Generate the receipt
            var receiptForm = new ReceiptForm
            {
                OrderedItems = GetOrderedItems(), // Retrieve ordered items
                TotalAmount = TotalPrice,
                CashReceived = cashReceived,
                CashBack = change
            };

            receiptForm.ShowDialog(); // Display the receipt
            this.Close(); // Close the payment popup
        }

        private List<string> GetOrderedItems()
        {
            List<string> items = new List<string>();


            foreach (DataGridViewRow row in this.DataGridView.Rows)
            {
                if (row.Cells["Drink"].Value != null)
                {
                    string drink = row.Cells["Drink"].Value.ToString();
                    string size = row.Cells["Size"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    items.Add($"{quantity}x {size} {drink} - {price:C}");
                }
            }

            return items;
        }

        private void PaymentPopup_Load(object sender, EventArgs e)
        {
            lblTotalAmount.Text = $"Total Amount: {TotalPrice:C}"; // Display total price

            foreach (var item in OrderedItems)
            {
                lstOrderedItems.Items.Add(item); // Display ordered items in a ListBox
            }
        }
        private void CashRecive_ValueChanged(object sender, EventArgs e)
        {
            decimal cashReceived = CashRecive.Value;
            decimal change = cashReceived - TotalPrice;

            lblCashBack.Text = change >= 0
                ? $"Change: {change:C}" // Show as currency if payment is sufficient
                : "Change: --"; // Placeholder if payment is insufficient
        }

        private void CashBack_Click(object sender, EventArgs e)
        {
            // Optional: Handle any logic if needed
        }

        private void TotalPrice_Click(object sender, EventArgs e)
        {
            // Optional: Handle any logic if needed
        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
    }



}
