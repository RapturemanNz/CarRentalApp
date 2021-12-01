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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities1 carRentalEntities1;
        public ManageUsers()
        {
            InitializeComponent();
            carRentalEntities1 = new CarRentalEntities1();
        }

        private void bAddNewUser_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }

        }

        private void bResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["ID"].Value;

                var user = carRentalEntities1.Users.FirstOrDefault(q => q.ID == id);
                var new_password = Utils.DefaultHashPassword();
                user.Password = new_password;
                carRentalEntities1.SaveChanges();

                MessageBox.Show($"{user.Username}'s Password has been reset");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["ID"].Value;

                var user = carRentalEntities1.Users.FirstOrDefault(q => q.ID == id);
                user.isActive = user.isActive == true ? false : true;
                carRentalEntities1.SaveChanges();

                MessageBox.Show($"{user.Username}'s active status has changed");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = carRentalEntities1.Users
                .Select(q => new
                {
                    q.ID,
                    q.Username,
                    q.UserRoles.FirstOrDefault().Role.name,
                    q.isActive
                })
                .ToList();
            gvUserList.DataSource = users;
            gvUserList.Columns["name"].HeaderText = "Role Name";
            gvUserList.Columns["isActive"].HeaderText = "Active";

            gvUserList.Columns["ID"].Visible = false;
        }
    }
}
