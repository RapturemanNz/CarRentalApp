namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.lManageVehicleListing = new System.Windows.Forms.Label();
            this.bAddNewCar = new System.Windows.Forms.Button();
            this.bDeleteCar = new System.Windows.Forms.Button();
            this.bEditCar = new System.Windows.Forms.Button();
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.bRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // lManageVehicleListing
            // 
            this.lManageVehicleListing.AutoSize = true;
            this.lManageVehicleListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lManageVehicleListing.Location = new System.Drawing.Point(109, 31);
            this.lManageVehicleListing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lManageVehicleListing.Name = "lManageVehicleListing";
            this.lManageVehicleListing.Size = new System.Drawing.Size(542, 55);
            this.lManageVehicleListing.TabIndex = 1;
            this.lManageVehicleListing.Text = "Manage Vehicle Listing";
            // 
            // bAddNewCar
            // 
            this.bAddNewCar.Location = new System.Drawing.Point(64, 313);
            this.bAddNewCar.Name = "bAddNewCar";
            this.bAddNewCar.Size = new System.Drawing.Size(108, 56);
            this.bAddNewCar.TabIndex = 2;
            this.bAddNewCar.Text = "Add New Car";
            this.bAddNewCar.UseVisualStyleBackColor = true;
            this.bAddNewCar.Click += new System.EventHandler(this.bAddNewCar_Click);
            // 
            // bDeleteCar
            // 
            this.bDeleteCar.Location = new System.Drawing.Point(405, 313);
            this.bDeleteCar.Name = "bDeleteCar";
            this.bDeleteCar.Size = new System.Drawing.Size(120, 56);
            this.bDeleteCar.TabIndex = 3;
            this.bDeleteCar.Text = "Delete Car";
            this.bDeleteCar.UseVisualStyleBackColor = true;
            this.bDeleteCar.Click += new System.EventHandler(this.bDeleteCar_Click);
            // 
            // bEditCar
            // 
            this.bEditCar.Location = new System.Drawing.Point(237, 313);
            this.bEditCar.Name = "bEditCar";
            this.bEditCar.Size = new System.Drawing.Size(113, 56);
            this.bEditCar.TabIndex = 4;
            this.bEditCar.Text = "Edit Car";
            this.bEditCar.UseVisualStyleBackColor = true;
            this.bEditCar.Click += new System.EventHandler(this.bEditCar_Click);
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(41, 106);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.Size = new System.Drawing.Size(678, 181);
            this.gvVehicleList.TabIndex = 0;
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(588, 313);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(113, 56);
            this.bRefresh.TabIndex = 5;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 430);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bEditCar);
            this.Controls.Add(this.bDeleteCar);
            this.Controls.Add(this.bAddNewCar);
            this.Controls.Add(this.lManageVehicleListing);
            this.Controls.Add(this.gvVehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lManageVehicleListing;
        private System.Windows.Forms.Button bAddNewCar;
        private System.Windows.Forms.Button bDeleteCar;
        private System.Windows.Forms.Button bEditCar;
        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Button bRefresh;
    }
}