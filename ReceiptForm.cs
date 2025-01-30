using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ExamWPFcoffee
{
    public partial class ReceiptForm : Form
    {
        public List<string> OrderedItems { get; set; } // List of ordered items
        public decimal TotalAmount { get; set; } // Total amount
        public decimal CashReceived { get; set; } // Cash received
        public decimal CashBack { get; set; } // Change to give back

        // Declare a PrintDocument object
        private PrintDocument printDocument;

        public ReceiptForm()
        {
            InitializeComponent();

            // Create the Print Receipt button
            Button btnPrintReceipt = new Button();
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(120, 40);
            btnPrintReceipt.Location = new Point(10, 300); // Position the button as needed
            btnPrintReceipt.Click += new EventHandler(this.btnPrintReceipt_Click);

            // Add the button to the form's controls
            this.Controls.Add(btnPrintReceipt);

            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        public ReceiptForm(List<string> orderedItems, decimal totalAmount, decimal cashReceived, decimal cashBack)
        {
            InitializeComponent();
            OrderedItems = orderedItems;
            TotalAmount = totalAmount;
            CashReceived = cashReceived;
            CashBack = cashBack;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            StringBuilder receiptText = new StringBuilder();
            receiptText.AppendLine("-------- Receipt --------");
            receiptText.AppendLine("Items Ordered:");

            foreach (var item in OrderedItems)
            {
                receiptText.AppendLine(item);
            }

            receiptText.AppendLine();
            receiptText.AppendLine($"Total Amount: {TotalAmount:C}");
            receiptText.AppendLine($"Cash Received: {CashReceived:C}");
            receiptText.AppendLine($"Change: {CashBack:C}");
            receiptText.AppendLine("---------------------------");
            receiptText.AppendLine("Thank you for your purchase!");

            receiptTextBox.Text = receiptText.ToString();
        }

        // Print the receipt when called
        public void PrintReceipt()
        {
            try
            {
                printDocument.Print(); // Trigger the print
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing receipt: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle the PrintPage event for custom printing
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set up the font for printing
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            // Start printing the receipt content
            float yPos = 20; // Starting position for text
            e.Graphics.DrawString("-------- Receipt --------", font, brush, 10, yPos);
            yPos += 20;

            e.Graphics.DrawString("Items Ordered:", font, brush, 10, yPos);
            yPos += 20;

            // Print each ordered item
            foreach (var item in OrderedItems)
            {
                e.Graphics.DrawString(item, font, brush, 10, yPos);
                yPos += 20;
            }

            // Print total, cash received, and change
            e.Graphics.DrawString($"Total Amount: {TotalAmount:C}", font, brush, 10, yPos);
            yPos += 20;

            e.Graphics.DrawString($"Cash Received: {CashReceived:C}", font, brush, 10, yPos);
            yPos += 20;

            e.Graphics.DrawString($"Change: {CashBack:C}", font, brush, 10, yPos);
            yPos += 20;

            e.Graphics.DrawString("---------------------------", font, brush, 10, yPos);
            yPos += 20;

            e.Graphics.DrawString("Thank you for your purchase!", font, brush, 10, yPos);
        }

        // Optional: Custom rendering for a receipt design
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Implement custom drawing if needed
        }

        private void receiptTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes in the receipt text box if needed
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintReceipt(); // Call the method to print the receipt
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and configure the PageSetupDialog
                PageSetupDialog pageSetupDialog = new PageSetupDialog();

                // Create a PrintDocument object to use as the context
                PrintDocument printDoc = new PrintDocument();
                pageSetupDialog.Document = printDoc;

                // Show the dialog to the user
                if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                {
                    // Apply the user-selected settings to the PrintDocument
                    printDoc.DefaultPageSettings = pageSetupDialog.PageSettings;

                    // Optional: Provide feedback to the user
                    MessageBox.Show("Page setup applied successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show($"An error occurred during page setup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
