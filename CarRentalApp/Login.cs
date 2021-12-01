using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities1 carRentalEntities1;
        public Login()
        {
            InitializeComponent();
            carRentalEntities1 = new CarRentalEntities1();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                var hashed_pass = Utils.HashPassword(password);

                var user = carRentalEntities1.Users.FirstOrDefault(q => q.Username ==username && 
                    q.Password == hashed_pass && q.isActive == true);
                if(user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainwindow = new MainWindow(this, user);
                    mainwindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again");
            }
        }
    }
}
