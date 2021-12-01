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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities1 carRentalEntities1;
        public ManageVehicleListing()
        {
            InitializeComponent();
            carRentalEntities1 = new CarRentalEntities1();
        }
        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //Selects ID and Name from CarTypes
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bAddNewCar_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditVehicle"))
            {
                var addEditVehicle = new AddEditVehicle(this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
        }

        private void bEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["ID"].Value;

                var car = carRentalEntities1.CarTypes.FirstOrDefault(q => q.ID == id);

                if(!Utils.FormIsOpen("AddEditVehicle"))
                { 
                    var addEditVehicle = new AddEditVehicle(car, this);
                    addEditVehicle.MdiParent = this.MdiParent;
                    addEditVehicle.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["ID"].Value;

                var car = carRentalEntities1.CarTypes.FirstOrDefault(q => q.ID == id);

                carRentalEntities1.CarTypes.Remove(car);
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

        public void PopulateGrid()
        {
            var cars = carRentalEntities1.CarTypes
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LincensePlateNumber,
                    ID = q.ID
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;

        }
    }
}
