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
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalEntities1 carRentalEntities1;
        public ManageRentalRecord()
        {
            InitializeComponent();
            carRentalEntities1 = new CarRentalEntities1();
        }

        private void bAddNewRecord_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditRentalRecord"))
            {
                var addRentalRecord = new AddEditRentalRecord();
                addRentalRecord.MdiParent = this.MdiParent;
                addRentalRecord.Show();
            }
        }

        private void bEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["ID"].Value;

                var record = carRentalEntities1.CarRentals.FirstOrDefault(q => q.ID == id);

                if (!Utils.FormIsOpen("AddEditRentalRecord"))
                {
                    var addEditRentalRecord = new AddEditRentalRecord(record);
                    addEditRentalRecord.MdiParent = this.MdiParent;
                    addEditRentalRecord.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["ID"].Value;

                var record = carRentalEntities1.CarRentals.FirstOrDefault(q => q.ID == id);

                carRentalEntities1.CarRentals.Remove(record);
                carRentalEntities1.SaveChanges();

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

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var records = carRentalEntities1.CarRentals
                .Select(q => new
                {
                    Customer = q.CustomerName,
                    DatePickup = q.DatePickup,
                    DateReturned = q.DateReturn,
                    Cost = q.Cost,
                    ID = q.ID,
                    Car = q.CarType.Make + " " + q.CarType.Model
                })
                .ToList();
            gvRecordList.DataSource = records;
            gvRecordList.Columns["DatePickup"].HeaderText = "Pickup Date";
            gvRecordList.Columns["DateReturned"].HeaderText = "Return Date";
            gvRecordList.Columns["ID"].Visible = false;

        }
    }
}
