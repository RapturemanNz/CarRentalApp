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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities1 carRentalEntities1;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageusers)
        {
            InitializeComponent();
            carRentalEntities1 = new CarRentalEntities1();
            _manageUsers = manageusers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = carRentalEntities1.Roles.ToList();
            cbRoles.DataSource = roles;
            cbRoles.ValueMember = "ID";
            cbRoles.DisplayMember ="Name";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUsername.Text;
                var RoleId = Convert.ToInt32(cbRoles.SelectedValue);
                var password = Utils.DefaultHashPassword();
                var user = new User()
                {
                    Username = username,
                    Password = password,
                    isActive = true,
                };
                carRentalEntities1.Users.Add(user);
                carRentalEntities1.SaveChanges();

                var userID = user.ID;
                var userRole = new UserRole
                {
                    roleID = RoleId,
                    userID = userID,
                };

                carRentalEntities1.UserRoles.Add(userRole);
                carRentalEntities1.SaveChanges();

                MessageBox.Show("New User has been added successfully");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Has Occured");
            }
        }
    }
}
