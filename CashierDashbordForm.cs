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
    public partial class CashierDashbordForm : Form
    {
        private List<string> selectedDrinks = new List<string>(); // Store selected drinks
        public CashierDashbordForm()
        {
            InitializeComponent();
        }

        private void CashierDashbordForm_Load(object sender, EventArgs e)
        {
            // Ensure columns are added to the DataGridView
            if (DataGridView.Columns.Count == 0)
            {
                DataGridView.Columns.Add("Drink", "Drink");
                DataGridView.Columns.Add("Size", "Size");
                DataGridView.Columns.Add("Quantity", "Quantity");
                DataGridView.Columns.Add("Cream", "Cream");
                DataGridView.Columns.Add("Sugar", "Sugar");
                DataGridView.Columns.Add("Shot", "Shot");
                DataGridView.Columns.Add("Price", "Price"); // Add Price column
            }
            // Add items to the ListView (Example for 5 items)
            listView1.Items.Add(new ListViewItem(new[] { "Ice Coffee", "$3.50" }));
            listView1.Items.Add(new ListViewItem(new[] { "Cappuccino Frappe", "$4.00" }));
            listView1.Items.Add(new ListViewItem(new[] { "Hot Cappuccino", "$3.00" }));
            listView1.Items.Add(new ListViewItem(new[] { "Ice Latte", "$3.75" }));
            listView1.Items.Add(new ListViewItem(new[] { "Hot Latte", "$3.25" }));
            //// Example of adding items to ListView
            //listView1.Items.Add("Espresso");
            //listView1.Items.Add("Latte");
            //listView1.Items.Add("Cappuccino");

            //lblTotalPrice.Text = "Total Price: $0.00"; // Initialize total price
            //listView1.Items.Add("Cappuccino");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected ListViewItem
                var selectedItem = listView1.SelectedItems[0];

                // Retrieve the selected drink name (Text is the first column)
                string selectedDrink = selectedItem.Text;

                // Retrieve the price (subitem at index 1)
                string selectedPrice = selectedItem.SubItems[1].Text;

                // Convert price to decimal for calculation purposes
                decimal price = Convert.ToDecimal(selectedPrice.TrimStart('$'));

                // Pass the selected drink name and price to the popup
                var popup = new SelectoptionPopup(selectedDrink, price);

                if (popup.ShowDialog(this) == DialogResult.OK)
                {
                    // Assuming the popup returns an Order object
                    var data = (Order)popup.Tag; // Retrieve the order data
                    AddToDataGridView(data, price);
                }
            }
        }
        private void AddToDataGridView(Order data, decimal price)
        {
            // Add the selected order to the DataGridView (assuming you have columns for Drink Name and Price)
            DataGridView.Rows.Add(data.Drink, $"${price}");
            CalculateTotalPrice();
        }


        public void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal totalPrice = CalculateTotalPrice();
            var orderedItems = GetOrderedItems(); // Retrieve items from DataGridView

            var paymentPopup = new PaymentPopup(totalPrice, orderedItems);
            paymentPopup.ShowDialog(this);
        }
        private List<string> GetOrderedItems()
        {
            List<string> items = new List<string>();

            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (row.Cells["Price"].Value != null)  // Ensure Price exists in the row
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

        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            // Loop through each row in the DataGridView and sum up the prices
            foreach (DataGridViewRow row in ataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)  // Check if the price cell is not null
                {
                    string priceString = row.Cells[1].Value.ToString();
                    decimal price = Convert.ToDecimal(priceString.TrimStart('$'));
                    totalPrice += price;
                }
            }

            // Return the total price
            return totalPrice;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddToDataGridView(dynamic data)
        {
            // Calculate price based on quantity, size, and extras
            decimal basePrice = GetBasePrice(data.Drink);
            decimal sizeMultiplier = GetSizeMultiplier(data.Size);
            decimal extrasCost = (data.Cream ? 0.5m : 0) + (data.Sugar ? 0.5m : 0) + (data.Shots * 0.5m);
            decimal totalPrice = (basePrice * sizeMultiplier + extrasCost) * data.Quantity;

            // Add a new row with the selected options and price
            DataGridView.Rows.Add(
                data.Drink,
                data.Size,
                data.Quantity,
                data.Cream ? "Yes" : "No",
                data.Sugar ? "Yes" : "No",
                data.Shots,
                totalPrice.ToString("C") // Format as currency
            );

            // Update total price
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Price"].Value.ToString().Trim('$'));
                }
            }

            lblTotalPrice.Text = $"Total Price: {total:C}"; // Format as currency
        }
        private decimal GetSizeMultiplier(string size)
        {
            return size switch
            {
                "S" => 1.0m,
                "L" => 1.5m,
                "XL" => 2.0m,
                _ => 1.0m // Default multiplier
            };
        }
        private decimal GetBasePrice(string drink)
        {
            return drink switch
            {
                "Espresso" => 2.0m,
                "Latte" => 3.0m,
                "Cappuccino" => 3.5m,
                _ => 2.0m // Default price
            };
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item from the ListView
                var selectedItem = listView1.SelectedItems[0];
                string selectedDrink = selectedItem.Text;

                // Pass the drink name to the popup
                var popup = new SelectoptionPopup(selectedDrink);
                if (popup.ShowDialog(this) == DialogResult.OK)
                {
                    // Retrieve data from popup
                    var orderData = (Order)popup.Tag;

                    // Add the selected options to the DataGridView
                    AddToOrder(orderData);
                }
            }

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridView.Rows.Clear(); // Clear all rows in the DataGridView
                lblTotalPrice.Text = "Total Price: $0.00";
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AddToDataGridView(Order data)
        {
            // Add a new row with the selected options
            DataGridView.Rows.Add(data.Drink, data.Size, data.Quantity, data.Cream ? "Yes" : "No", data.Sugar ? "Yes" : "No", data.Shots);
        }

        public void AddToOrder(Order order)
        {
            // Method to add an order to the DataGridView
            if (order == null)
                return;

            // Add order logic
            DataGridView.Rows.Add(order.Drink, order.Size, order.Quantity, order.Cream ? "Yes" : "No", order.Sugar ? "Yes" : "No", order.Shots);
        }



        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    public class Order
    {
        public string Drink { get; set; } = string.Empty; // Default value
        public string Size { get; set; } = string.Empty;  // Default value
        public int Quantity { get; set; }
        public bool Cream { get; set; }
        public bool Sugar { get; set; }
        public int Shots { get; set; }
    }

}

