namespace CarRentalApp
{
    partial class AddEditRentalRecord
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
            this.lAddEditTitle = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lCustomerName = new System.Windows.Forms.Label();
            this.dtPickup = new System.Windows.Forms.DateTimePicker();
            this.lPickUpD = new System.Windows.Forms.Label();
            this.lReturnD = new System.Windows.Forms.Label();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.lCarType = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.lCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lRecord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAddEditTitle
            // 
            this.lAddEditTitle.AutoSize = true;
            this.lAddEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddEditTitle.Location = new System.Drawing.Point(361, 39);
            this.lAddEditTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAddEditTitle.Name = "lAddEditTitle";
            this.lAddEditTitle.Size = new System.Drawing.Size(264, 55);
            this.lAddEditTitle.TabIndex = 0;
            this.lAddEditTitle.Text = "Car Rental";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(20, 180);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(460, 26);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lCustomerName
            // 
            this.lCustomerName.AutoSize = true;
            this.lCustomerName.Location = new System.Drawing.Point(20, 151);
            this.lCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCustomerName.Name = "lCustomerName";
            this.lCustomerName.Size = new System.Drawing.Size(137, 20);
            this.lCustomerName.TabIndex = 2;
            this.lCustomerName.Text = "Customer Name";
            // 
            // dtPickup
            // 
            this.dtPickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickup.Location = new System.Drawing.Point(20, 268);
            this.dtPickup.Name = "dtPickup";
            this.dtPickup.Size = new System.Drawing.Size(311, 26);
            this.dtPickup.TabIndex = 3;
            // 
            // lPickUpD
            // 
            this.lPickUpD.AutoSize = true;
            this.lPickUpD.Location = new System.Drawing.Point(20, 245);
            this.lPickUpD.Name = "lPickUpD";
            this.lPickUpD.Size = new System.Drawing.Size(114, 20);
            this.lPickUpD.TabIndex = 4;
            this.lPickUpD.Text = "Date Pick Up";
            // 
            // lReturnD
            // 
            this.lReturnD.AutoSize = true;
            this.lReturnD.Location = new System.Drawing.Point(355, 245);
            this.lReturnD.Name = "lReturnD";
            this.lReturnD.Size = new System.Drawing.Size(108, 20);
            this.lReturnD.TabIndex = 6;
            this.lReturnD.Text = "Date Return";
            // 
            // dtReturn
            // 
            this.dtReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturn.Location = new System.Drawing.Point(355, 268);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(311, 26);
            this.dtReturn.TabIndex = 5;
            // 
            // cbCarType
            // 
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Location = new System.Drawing.Point(20, 346);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(311, 28);
            this.cbCarType.TabIndex = 7;
            // 
            // lCarType
            // 
            this.lCarType.AutoSize = true;
            this.lCarType.Location = new System.Drawing.Point(20, 323);
            this.lCarType.Name = "lCarType";
            this.lCarType.Size = new System.Drawing.Size(98, 20);
            this.lCarType.TabIndex = 8;
            this.lCarType.Text = "Type of car";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(20, 412);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(114, 59);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(549, 151);
            this.lCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(46, 20);
            this.lCost.TabIndex = 11;
            this.lCost.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(549, 180);
            this.tbCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(242, 26);
            this.tbCost.TabIndex = 10;
            // 
            // lRecord
            // 
            this.lRecord.AutoSize = true;
            this.lRecord.Location = new System.Drawing.Point(555, 414);
            this.lRecord.Name = "lRecord";
            this.lRecord.Size = new System.Drawing.Size(0, 20);
            this.lRecord.TabIndex = 12;
            this.lRecord.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.lRecord);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lCarType);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.lReturnD);
            this.Controls.Add(this.dtReturn);
            this.Controls.Add(this.lPickUpD);
            this.Controls.Add(this.dtPickup);
            this.Controls.Add(this.lCustomerName);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lAddEditTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEditRentalRecord";
            this.Text = "Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddEditTitle;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lCustomerName;
        private System.Windows.Forms.DateTimePicker dtPickup;
        private System.Windows.Forms.Label lPickUpD;
        private System.Windows.Forms.Label lReturnD;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label lCarType;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lRecord;
    }
}

