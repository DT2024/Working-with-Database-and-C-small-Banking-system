using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Assignment4_Dariya_N01633069.Models.Entities;
using Assignment4_Dariya_N01633069;

namespace Assignment3_Darius
{
    public partial class Login : Form
    {
        private readonly ASSN4DBContext dbContext;

        public Login()
        {
            InitializeComponent();
            dbContext = new ASSN4DBContext();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter something as the textfields can't be empty");
                return;
            }

            try
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password); //only authenticated users using Linq

                if (user != null)
                {
                    MessageBox.Show("Successful Login, Welcome back!");
                    int userID = user.Id;

                    Form1 form= new(userID);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login, Incorrect Email or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing your request. Please try again later.");
                // Log the exception
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


      
    }
}
