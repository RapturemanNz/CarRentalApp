using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities1 carRentalEntities1;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            carRentalEntities1 = new CarRentalEntities1();
            _user = user;
        }

        private void bResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbPassword.Text;
                var confirmPass = tbConfirmPass.Text;
                var user = carRentalEntities1.Users.FirstOrDefault(q => q.ID == _user.ID);

                if (password != confirmPass)
                {
                    MessageBox.Show("Passwords do not match. Please try again");
                }

                user.Password = Utils.HashPassword(password);
                carRentalEntities1.SaveChanges();
                MessageBox.Show("Password was Reset Successfully");
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occured please try again");
            }
        }
    }
}
