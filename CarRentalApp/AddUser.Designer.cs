namespace CarRentalApp
{
    partial class AddUser
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
            this.lAddUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lUsername = new System.Windows.Forms.Label();
            this.lRole = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lAddUser
            // 
            this.lAddUser.AutoSize = true;
            this.lAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddUser.Location = new System.Drawing.Point(129, 30);
            this.lAddUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAddUser.Name = "lAddUser";
            this.lAddUser.Size = new System.Drawing.Size(233, 55);
            this.lAddUser.TabIndex = 1;
            this.lAddUser.Text = "Add User";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lRole, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbRoles, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 161);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(3, 0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(92, 22);
            this.lUsername.TabIndex = 1;
            this.lUsername.Text = "Username";
            // 
            // lRole
            // 
            this.lRole.AutoSize = true;
            this.lRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRole.Location = new System.Drawing.Point(3, 80);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(47, 22);
            this.lRole.TabIndex = 3;
            this.lRole.Text = "Role";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(162, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(154, 20);
            this.tbUsername.TabIndex = 10;
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(162, 83);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(154, 21);
            this.cbRoles.TabIndex = 11;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(259, 289);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(113, 56);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(96, 289);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(113, 56);
            this.bSubmit.TabIndex = 14;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 374);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lAddUser);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSubmit;
    }
}