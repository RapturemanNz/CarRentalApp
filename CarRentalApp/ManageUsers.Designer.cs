namespace CarRentalApp
{
    partial class ManageUsers
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
            this.bResetPassword = new System.Windows.Forms.Button();
            this.bDeactivate = new System.Windows.Forms.Button();
            this.bAddNewUser = new System.Windows.Forms.Button();
            this.lManageUsers = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(608, 338);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(113, 56);
            this.bRefresh.TabIndex = 17;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bResetPassword
            // 
            this.bResetPassword.Location = new System.Drawing.Point(257, 338);
            this.bResetPassword.Name = "bResetPassword";
            this.bResetPassword.Size = new System.Drawing.Size(113, 56);
            this.bResetPassword.TabIndex = 16;
            this.bResetPassword.Text = "Reset Password";
            this.bResetPassword.UseVisualStyleBackColor = true;
            this.bResetPassword.Click += new System.EventHandler(this.bResetPassword_Click);
            // 
            // bDeactivate
            // 
            this.bDeactivate.Location = new System.Drawing.Point(425, 338);
            this.bDeactivate.Name = "bDeactivate";
            this.bDeactivate.Size = new System.Drawing.Size(120, 56);
            this.bDeactivate.TabIndex = 15;
            this.bDeactivate.Text = "Deactivate User";
            this.bDeactivate.UseVisualStyleBackColor = true;
            this.bDeactivate.Click += new System.EventHandler(this.bDeactivate_Click);
            // 
            // bAddNewUser
            // 
            this.bAddNewUser.Location = new System.Drawing.Point(84, 338);
            this.bAddNewUser.Name = "bAddNewUser";
            this.bAddNewUser.Size = new System.Drawing.Size(108, 56);
            this.bAddNewUser.TabIndex = 14;
            this.bAddNewUser.Text = "Add User";
            this.bAddNewUser.UseVisualStyleBackColor = true;
            this.bAddNewUser.Click += new System.EventHandler(this.bAddNewUser_Click);
            // 
            // lManageUsers
            // 
            this.lManageUsers.AutoSize = true;
            this.lManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lManageUsers.Location = new System.Drawing.Point(209, 47);
            this.lManageUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lManageUsers.Name = "lManageUsers";
            this.lManageUsers.Size = new System.Drawing.Size(350, 55);
            this.lManageUsers.TabIndex = 13;
            this.lManageUsers.Text = "Manage Users";
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(61, 131);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.Size = new System.Drawing.Size(678, 181);
            this.gvUserList.TabIndex = 12;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bResetPassword);
            this.Controls.Add(this.bDeactivate);
            this.Controls.Add(this.bAddNewUser);
            this.Controls.Add(this.lManageUsers);
            this.Controls.Add(this.gvUserList);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bResetPassword;
        private System.Windows.Forms.Button bDeactivate;
        private System.Windows.Forms.Button bAddNewUser;
        private System.Windows.Forms.Label lManageUsers;
        private System.Windows.Forms.DataGridView gvUserList;
    }
}