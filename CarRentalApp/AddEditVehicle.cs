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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities1 carRentalEntities1;

        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lTitle.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            carRentalEntities1 = new CarRentalEntities1();
        }

        public AddEditVehicle(CarType carToEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lTitle.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carToEdit == null)
            {
                MessageBox.Show("Please ensure that you have selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                carRentalEntities1 = new CarRentalEntities1();
                PopulateFields(carToEdit);
            }
        }

        private void PopulateFields(CarType car)
        {
            lID.Text = car.ID.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicensePlateNumber.Text = car.LincensePlateNumber;
        }

        private void bSaveChanges_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                var id = Convert.ToInt32(lID.Text);
                var car = carRentalEntities1.CarTypes.FirstOrDefault(q => q.ID == id);
                car.Make = tbMake.Text;
                car.Model = tbModel.Text;
                car.VIN = tbVIN.Text;
                car.Year = Convert.ToInt32(tbYear.Text);
                car.LincensePlateNumber = tbLicensePlateNumber.Text;

                carRentalEntities1.SaveChanges();
                _manageVehicleListing.PopulateGrid();

                MessageBox.Show("Car has been edited");
                Close();
            }
            else
            {
                var newCar = new CarType
                {
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    VIN = tbVIN.Text,
                    Year = Convert.ToInt32(tbYear.Text),
                    LincensePlateNumber = tbLicensePlateNumber.Text
                };

                carRentalEntities1.CarTypes.Add(newCar);
                carRentalEntities1.SaveChanges();
                _manageVehicleListing.PopulateGrid();

                MessageBox.Show("New Car has been added");
                Close();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
