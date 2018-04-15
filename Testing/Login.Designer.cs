namespace Testing
{
    partial class Login
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
            this.lbl_auth = new System.Windows.Forms.Label();
            this.txbx_login = new System.Windows.Forms.TextBox();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_auth
            // 
            this.lbl_auth.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_auth.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_auth.ForeColor = System.Drawing.Color.White;
            this.lbl_auth.Location = new System.Drawing.Point(0, 0);
            this.lbl_auth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_auth.Name = "lbl_auth";
            this.lbl_auth.Size = new System.Drawing.Size(350, 60);
            this.lbl_auth.TabIndex = 0;
            this.lbl_auth.Text = "АВТОРИЗАЦІЯ";
            this.lbl_auth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbx_login
            // 
            this.txbx_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_login.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_login.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txbx_login.Location = new System.Drawing.Point(12, 72);
            this.txbx_login.Name = "txbx_login";
            this.txbx_login.Size = new System.Drawing.Size(326, 41);
            this.txbx_login.TabIndex = 1;
            this.txbx_login.Text = "Логін";
            this.txbx_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbx_password
            // 
            this.txbx_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbx_password.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_password.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txbx_password.Location = new System.Drawing.Point(12, 125);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(326, 41);
            this.txbx_password.TabIndex = 2;
            this.txbx_password.Text = "Пароль";
            this.txbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(12, 178);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(157, 41);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "ОК";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btn_exit.FlatAppearance.BorderSize = 2;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_exit.Location = new System.Drawing.Point(181, 178);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(157, 41);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "ВИЙТИ";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 231);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_login);
            this.Controls.Add(this.lbl_auth);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_auth;
        private System.Windows.Forms.TextBox txbx_login;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_exit;
    }
}