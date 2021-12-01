namespace CarRentalApp
{
    partial class ManageRentalRecord
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
            this.bRefresh = new System.Windows.Forms.Button();
            this.bEditRecord = new System.Windows.Forms.Button();
            this.bDeleteRecord = new System.Windows.Forms.Button();
            this.bAddNewRecord = new System.Windows.Forms.Button();
            this.lManageRentalRecords = new System.Windows.Forms.Label();
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(608, 338);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(113, 56);
            this.bRefresh.TabIndex = 11;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bEditRecord
            // 
            this.bEditRecord.Location = new System.Drawing.Point(257, 338);
            this.bEditRecord.Name = "bEditRecord";
            this.bEditRecord.Size = new System.Drawing.Size(113, 56);
            this.bEditRecord.TabIndex = 10;
            this.bEditRecord.Text = "Edit Record";
            this.bEditRecord.UseVisualStyleBackColor = true;
            this.bEditRecord.Click += new System.EventHandler(this.bEditRecord_Click);
            // 
            // bDeleteRecord
            // 
            this.bDeleteRecord.Location = new System.Drawing.Point(425, 338);
            this.bDeleteRecord.Name = "bDeleteRecord";
            this.bDeleteRecord.Size = new System.Drawing.Size(120, 56);
            this.bDeleteRecord.TabIndex = 9;
            this.bDeleteRecord.Text = "Delete Record";
            this.bDeleteRecord.UseVisualStyleBackColor = true;
            this.bDeleteRecord.Click += new System.EventHandler(this.bDeleteRecord_Click);
            // 
            // bAddNewRecord
            // 
            this.bAddNewRecord.Location = new System.Drawing.Point(84, 338);
            this.bAddNewRecord.Name = "bAddNewRecord";
            this.bAddNewRecord.Size = new System.Drawing.Size(108, 56);
            this.bAddNewRecord.TabIndex = 8;
            this.bAddNewRecord.Text = "Add New Record";
            this.bAddNewRecord.UseVisualStyleBackColor = true;
            this.bAddNewRecord.Click += new System.EventHandler(this.bAddNewRecord_Click);
            // 
            // lManageRentalRecords
            // 
            this.lManageRentalRecords.AutoSize = true;
            this.lManageRentalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lManageRentalRecords.Location = new System.Drawing.Point(129, 56);
            this.lManageRentalRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lManageRentalRecords.Name = "lManageRentalRecords";
            this.lManageRentalRecords.Size = new System.Drawing.Size(565, 55);
            this.lManageRentalRecords.TabIndex = 7;
            this.lManageRentalRecords.Text = "Manage Rental Records";
            // 
            // gvRecordList
            // 
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(61, 131);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.Size = new System.Drawing.Size(678, 181);
            this.gvRecordList.TabIndex = 6;
            // 
            // ManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bEditRecord);
            this.Controls.Add(this.bDeleteRecord);
            this.Controls.Add(this.bAddNewRecord);
            this.Controls.Add(this.lManageRentalRecords);
            this.Controls.Add(this.gvRecordList);
            this.Name = "ManageRentalRecord";
            this.Text = "Manage Rental Record";
            this.Load += new System.EventHandler(this.ManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bEditRecord;
        private System.Windows.Forms.Button bDeleteRecord;
        private System.Windows.Forms.Button bAddNewRecord;
        private System.Windows.Forms.Label lManageRentalRecords;
        private System.Windows.Forms.DataGridView gvRecordList;
    }
}