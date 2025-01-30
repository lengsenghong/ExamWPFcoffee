using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
//using OfficeOpenXml;
using System.IO;

namespace ExamWPFcoffee
{
    public partial class AdminDashboardForm : Form
    {
        private List<Staff> staffList = new List<Staff>();
        private List<Drink> drinkList = new List<Drink>();
        public string? Position { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Category { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class Staff
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public string Contact { get; set; }
        }
        public class Drink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
        }
        public AdminDashboardForm()
        {
            InitializeComponent();
        }


        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Initialize DataGridView columns for staff
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Position", "Position");
                dataGridView1.Columns.Add("Contact", "Contact");
            }

            // Initialize Drink Tab (optional: another DataGridView in tabControl1)
            var drinkTab = tabControl1.TabPages["Drinks"];
            var drinkDataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                Name = "drinkDataGridView"
            };

            drinkDataGridView.Columns.Add("Name", "Name");
            drinkDataGridView.Columns.Add("Price", "Price");
            drinkDataGridView.Columns.Add("Category", "Category");

            drinkTab.Controls.Add(drinkDataGridView);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            // Open a dialog or get input for new staff
            var staffName = Prompt.ShowDialog("Enter Staff Name", "Add Staff");
            var position = Prompt.ShowDialog("Enter Position", "Add Staff");
            var contact = Prompt.ShowDialog("Enter Contact Info", "Add Staff");

            if (!string.IsNullOrEmpty(staffName))
            {
                // Add to staff list
                var newStaff = new Staff
                {
                    Name = staffName,
                    Position = position,
                    Contact = contact
                };
                staffList.Add(newStaff);

                // Update DataGridView
                dataGridView1.Rows.Add(newStaff.Name, newStaff.Position, newStaff.Contact);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            // Open a dialog or get input for new drink
            var drinkName = Prompt.ShowDialog("Enter Drink Name", "Add Drink");
            var price = decimal.Parse(Prompt.ShowDialog("Enter Price", "Add Drink"));
            var category = Prompt.ShowDialog("Enter Category", "Add Drink");

            if (!string.IsNullOrEmpty(drinkName))
            {
                // Add to drink list
                var newDrink = new Drink
                {
                    Name = drinkName,
                    Price = price,
                    Category = category
                };
                drinkList.Add(newDrink);

                // Update Drink DataGridView
                var drinkTab = tabControl1.TabPages["Drinks"];
                var drinkDataGridView = (DataGridView)drinkTab.Controls["drinkDataGridView"];
                drinkDataGridView.Rows.Add(newDrink.Name, newDrink.Price.ToString("C"), newDrink.Category);
            }
        }
        // Helper class for input dialogs
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 400 };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 80 };
                confirmation.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                prompt.ShowDialog();
                return inputBox.Text;
            }
        }

        private void drinkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}