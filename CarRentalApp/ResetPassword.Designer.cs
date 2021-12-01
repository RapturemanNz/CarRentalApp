namespace CarRentalApp
{
    partial class ResetPassword
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
            this.lConfirmPass = new System.Windows.Forms.Label();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bResetPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lConfirmPass
            // 
            this.lConfirmPass.AutoSize = true;
            this.lConfirmPass.Location = new System.Drawing.Point(126, 65);
            this.lConfirmPass.Name = "lConfirmPass";
            this.lConfirmPass.Size = new System.Drawing.Size(91, 13);
            this.lConfirmPass.TabIndex = 3;
            this.lConfirmPass.Text = "Confirm Password";
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Location = new System.Drawing.Point(77, 90);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.PasswordChar = '*';
            this.tbConfirmPass.Size = new System.Drawing.Size(199, 20);
            this.tbConfirmPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter New Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(77, 35);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(199, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // bResetPass
            // 
            this.bResetPass.Location = new System.Drawing.Point(113, 125);
            this.bResetPass.Name = "bResetPass";
            this.bResetPass.Size = new System.Drawing.Size(119, 39);
            this.bResetPass.TabIndex = 6;
            this.bResetPass.Text = "Reset Password";
            this.bResetPass.UseVisualStyleBackColor = true;
            this.bResetPass.Click += new System.EventHandler(this.bResetPass_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 176);
            this.Controls.Add(this.bResetPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lConfirmPass);
            this.Controls.Add(this.tbConfirmPass);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lConfirmPass;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bResetPass;
    }
}