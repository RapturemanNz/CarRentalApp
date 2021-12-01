namespace CarRentalApp
{
    partial class AddEditVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bSaveChanges = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.lMake = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lVIN = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lLicensePlateNumber = new System.Windows.Forms.Label();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbLicensePlateNumber = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.20353F));
            this.tableLayoutPanel1.Controls.Add(this.tbLicensePlateNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbVIN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lLicensePlateNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lYear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lVIN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lModel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbMake, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lMake, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bSaveChanges
            // 
            this.bSaveChanges.Location = new System.Drawing.Point(42, 358);
            this.bSaveChanges.Name = "bSaveChanges";
            this.bSaveChanges.Size = new System.Drawing.Size(327, 58);
            this.bSaveChanges.TabIndex = 1;
            this.bSaveChanges.Text = "Save Changes";
            this.bSaveChanges.UseVisualStyleBackColor = true;
            this.bSaveChanges.Click += new System.EventHandler(this.bSaveChanges_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(423, 358);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(327, 58);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(120, 19);
            this.lTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(0, 55);
            this.lTitle.TabIndex = 3;
            // 
            // lMake
            // 
            this.lMake.AutoSize = true;
            this.lMake.Location = new System.Drawing.Point(3, 0);
            this.lMake.Name = "lMake";
            this.lMake.Size = new System.Drawing.Size(34, 13);
            this.lMake.TabIndex = 0;
            this.lMake.Text = "Make";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Location = new System.Drawing.Point(3, 47);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(36, 13);
            this.lModel.TabIndex = 2;
            this.lModel.Text = "Model";
            // 
            // lVIN
            // 
            this.lVIN.AutoSize = true;
            this.lVIN.Location = new System.Drawing.Point(3, 94);
            this.lVIN.Name = "lVIN";
            this.lVIN.Size = new System.Drawing.Size(25, 13);
            this.lVIN.TabIndex = 4;
            this.lVIN.Text = "VIN";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(3, 141);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(29, 13);
            this.lYear.TabIndex = 6;
            this.lYear.Text = "Year";
            // 
            // lLicensePlateNumber
            // 
            this.lLicensePlateNumber.AutoSize = true;
            this.lLicensePlateNumber.Location = new System.Drawing.Point(3, 188);
            this.lLicensePlateNumber.Name = "lLicensePlateNumber";
            this.lLicensePlateNumber.Size = new System.Drawing.Size(111, 13);
            this.lLicensePlateNumber.TabIndex = 8;
            this.lLicensePlateNumber.Text = "License Plate Number";
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(370, 3);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(283, 20);
            this.tbMake.TabIndex = 9;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(370, 50);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(283, 20);
            this.tbModel.TabIndex = 10;
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(370, 97);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(283, 20);
            this.tbVIN.TabIndex = 11;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(370, 144);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(283, 20);
            this.tbYear.TabIndex = 12;
            // 
            // tbLicensePlateNumber
            // 
            this.tbLicensePlateNumber.Location = new System.Drawing.Point(370, 191);
            this.tbLicensePlateNumber.Name = "tbLicensePlateNumber";
            this.tbLicensePlateNumber.Size = new System.Drawing.Size(283, 20);
            this.tbLicensePlateNumber.TabIndex = 13;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(369, 61);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(0, 13);
            this.lID.TabIndex = 4;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSaveChanges);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.Text = "AddEditVehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bSaveChanges;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbLicensePlateNumber;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lLicensePlateNumber;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lVIN;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Label lMake;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lID;
    }
}