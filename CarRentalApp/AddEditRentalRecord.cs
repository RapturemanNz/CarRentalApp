using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities1 carRentalEntities1;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            lAddEditTitle.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            carRentalEntities1 = new CarRentalEntities1();
        }

        public AddEditRentalRecord(CarRental recordToEdit)
        {
            InitializeComponent();
            lAddEditTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you have selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                carRentalEntities1 = new CarRentalEntities1();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRental recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName;
            dtPickup.Value = Convert.ToDateTime(recordToEdit.DatePickup);
            dtReturn.Value = Convert.ToDateTime(recordToEdit.DateReturn);
            tbCost.Text = Convert.ToString(recordToEdit.Cost);   
            lRecord.Text = Convert.ToString(recordToEdit.ID);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cusName = tbCustomerName.Text;
                var datePickup = dtPickup.Value;
                var dateReturn = dtReturn.Value;
                var carType = cbCarType.Text;
                var cost = Convert.ToDouble(tbCost.Text);
                var validCheck = true;

                if (string.IsNullOrWhiteSpace(cusName) || string.IsNullOrWhiteSpace(carType))
                {
                    MessageBox.Show("Please correctly enter a name and select a car type");
                    validCheck = false;
                }

                if (datePickup > dateReturn)
                {
                    MessageBox.Show("The selected date is an invalid date, please choose another");
                    validCheck = false;
                }

                if (validCheck == true)
                {
                    if (isEditMode == true)
                    {
                        var id = Convert.ToInt32(lRecord.Text);
                        var record = carRentalEntities1.CarRentals.FirstOrDefault(q => q.ID == id);
                    }

                    var rentalRecord = new CarRental();
                    rentalRecord.CustomerName = cusName;
                    rentalRecord.DatePickup = datePickup;
                    rentalRecord.DateReturn = dateReturn;
                    rentalRecord.Cost = Convert.ToDecimal(cost);
                    rentalRecord.CarTypeID = Convert.ToInt32(cbCarType.SelectedValue);

                    if(isEditMode == false)
                    {
                        carRentalEntities1.CarRentals.Add(rentalRecord);
                    }

                    carRentalEntities1.SaveChanges();

                    MessageBox.Show($"Customer Name: {cusName} \n\r" +
                        $"Pickup Date: {datePickup}\n\r" +
                        $"Return Date: {dateReturn} \n\r" +
                        $"Car Type: {carType} \n\r" +
                        $"Cost: {cost}\n\r" +
                        $"Thanks Friend <3");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities1.CarTypes
                .Select(q => new
                {
                    ID = q.ID,
                    Name = q.Make + " " + q.Model
                })
                .ToList();
            cbCarType.DisplayMember = "Name";
            cbCarType.ValueMember = "ID";
            cbCarType.DataSource = cars;
        }
    }
}
