using Assignment4_Dariya_N01633069.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Assignment4_Dariya_N01633069
{
    public partial class Form1 : Form
    {
        private readonly ASSN4DBContext dbContext;
        public readonly int userID; // Store the user ID
        public Form1(int userID)
        {
            InitializeComponent();
            dbContext = new ASSN4DBContext();
            this.userID = userID; // Store the provided user ID

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadAccountDetails(userID);
            LoadTransactionHistory(userID);

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void LoadAccountDetails(int userID)
        {
            try
            {
                // getting information from the database using join method to get the usefull information of the user
                var query = from account in dbContext.Accounts
                            join user in dbContext.Users on account.UserId equals user.Id
                            where user.Id == userID
                            select new
                            {
                                account.AccountType,
                                account.CurrentBalance,
                                FullName = user.Firstname + " " + user.Lastname,
                                account.DateCreated

                            };

                var accountDetails = query.FirstOrDefault();

                if (accountDetails != null)
                {

                    textBox1.Text = accountDetails.AccountType;
                    textBox2.Text = accountDetails.CurrentBalance.ToString(); // because it is numeric
                    textBox4.Text = accountDetails.FullName;
                    textBox3.Text = accountDetails.DateCreated.ToString();  //type of date datatype
                }
                else
                {
                    MessageBox.Show("No account found for the logged-in user.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading account details. Please try again later.");

            }
        }
        private void LoadTransactionHistory(int userID)
        {
            try
            {
                // joining the account informations based on accountId;
                var query2 = from transaction in dbContext.TransactionHistories
                             join account in dbContext.Accounts on transaction.AccountId equals account.AccountId
                             where account.UserId == userID
                             select new
                             {
                                 transaction.Description,
                                 transaction.Amount,
                                 transaction.TransactionDate
                             };

                // Clear existing rows in the DataGridView
                dataGridView1.Rows.Clear();  //it is used to clear needed , as later update or deleting are implemented

                // Add each transaction to the DataGridView
                foreach (var transaction in query2)     //if there are more than 1 transaction for the same userid (account id)(user  id)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = transaction.Amount;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = transaction.Description;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = transaction.TransactionDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading transaction history. Please try again later.");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Retrieve the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve the transaction details from the selected row
                decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);
                string description = Convert.ToString(selectedRow.Cells["Description"].Value);
                DateTime transactionDate = Convert.ToDateTime(selectedRow.Cells["TransactionDate"].Value);

                // Find the transaction based on the retrieved details
                var transaction = dbContext.TransactionHistories.FirstOrDefault(t =>
                    t.Amount == amount &&
                    t.Description == description &&
                    t.TransactionDate == transactionDate);

                if (transaction != null)
                {
                   
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Update the account balance by subtracting the amount
                        var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == transaction.AccountId);
                        if (account != null)
                        {
                            account.CurrentBalance -= Convert.ToDouble(transaction.Amount);
                            dbContext.SaveChanges();
                            textBox2.Text = account.CurrentBalance.ToString(); // Update the text box with the new current balance
                        }

                        
                        dbContext.TransactionHistories.Remove(transaction);
                        dbContext.SaveChanges();

                        // Refresh the DataGridView
                        LoadTransactionHistory(userID);
                    }
                }
                else
                {
                    MessageBox.Show("Transaction not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

    }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate amount input
            if (!decimal.TryParse(textBox5.Text, out decimal newAmount))
            {
                MessageBox.Show("Invalid amount input");
                return;
            }

            // Retrieve the selected row
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to update.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            decimal oldAmount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);
            string description = Convert.ToString(selectedRow.Cells["Description"].Value);
            DateTime transactionDate = Convert.ToDateTime(selectedRow.Cells["TransactionDate"].Value);

            // Find the transaction based on the retrieved details
            var transaction = dbContext.TransactionHistories.FirstOrDefault(t =>
                t.Amount == oldAmount &&
                t.Description == description &&
                t.TransactionDate == transactionDate);

            if (transaction == null)
            {
                MessageBox.Show("Transaction not found.");
                return;
            }

            // Retrieve the account associated with the transaction
            var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == transaction.AccountId);
            if (account == null)
            {
                MessageBox.Show("Associated account not found.");
                return;
            }

            // Calculate the difference between the old and new amounts
            decimal amountDifference = newAmount - oldAmount;

            // Update the account balance by adding the difference
            account.CurrentBalance += Convert.ToDouble(amountDifference);
            dbContext.SaveChanges();
            textBox2.Text = account.CurrentBalance.ToString(); // Update the text box with the new current balance

            // Update the transaction amount in the database
            transaction.Amount = newAmount;
            dbContext.SaveChanges();

            MessageBox.Show("Transaction history is updated successfully");

            // Reload account details and transaction history
            LoadAccountDetails(userID);
            LoadTransactionHistory(userID);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionHistory = new TransactionHistory();

            // Validate description input
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Description is required");
                return;
            }

            transactionHistory.Description = textBox6.Text;
            transactionHistory.AccountId = dbContext.Accounts
                .Where(account => account.UserId == userID)
                .Select(account => account.AccountId)
                .FirstOrDefault();

            if (transactionHistory.AccountId == null)
            {
                MessageBox.Show("User account not found.");
                return;
            }

            // Convert the text to decimal for Amount
            if (decimal.TryParse(textBox5.Text, out decimal amount))
            {
                transactionHistory.Amount = amount;
            }
            else
            {
               
                MessageBox.Show("Invalid amount input");
                return;
            }

            // Convert the text to DateTime for TransactionDate
            if (DateTime.TryParse(dateTimePicker1.Text, out DateTime transactionDate))
            {
                transactionHistory.TransactionDate = transactionDate;
            }
            else
            {
                
                MessageBox.Show("Invalid date input");
                return;
            }

            // Add transaction history to the database
            dbContext.TransactionHistories.Add(transactionHistory);
            dbContext.SaveChanges();

            // Update account balance by adding the amount
            var account = dbContext.Accounts.FirstOrDefault(a => a.AccountId == transactionHistory.AccountId);
            if (account != null)
            {
                account.CurrentBalance += Convert.ToDouble(transactionHistory.Amount);
                dbContext.SaveChanges();
                textBox2.Text = account.CurrentBalance.ToString(); // Update the text box with the new current balance
            }

            MessageBox.Show("Transaction history is added successfully");

            // Reload account details and transaction history
            LoadAccountDetails(userID);
            LoadTransactionHistory(userID);
        
    }

       
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            textBox5.Text = Convert.ToString(dataGridView1[0, row].Value);
            textBox6.Text = Convert.ToString(dataGridView1[1, row].Value);
            dateTimePicker1.Text= Convert.ToString(dataGridView1[2, row].Value);
        }

    
        
    }
}