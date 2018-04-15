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
            this.label1 = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.oklogin = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "АВТОРИЗАЦІЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbox.ForeColor = System.Drawing.Color.Silver;
            this.loginbox.Location = new System.Drawing.Point(12, 72);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(326, 41);
            this.loginbox.TabIndex = 1;
            this.loginbox.Text = "Логін";
            this.loginbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordbox.ForeColor = System.Drawing.Color.Silver;
            this.passwordbox.Location = new System.Drawing.Point(12, 125);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(326, 41);
            this.passwordbox.TabIndex = 2;
            this.passwordbox.Text = "Пароль";
            this.passwordbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oklogin
            // 
            this.oklogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.oklogin.FlatAppearance.BorderSize = 0;
            this.oklogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oklogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oklogin.ForeColor = System.Drawing.Color.White;
            this.oklogin.Location = new System.Drawing.Point(12, 178);
            this.oklogin.Name = "oklogin";
            this.oklogin.Size = new System.Drawing.Size(157, 41);
            this.oklogin.TabIndex = 3;
            this.oklogin.Text = "ОК";
            this.oklogin.UseVisualStyleBackColor = false;
            this.oklogin.Click += new System.EventHandler(this.oklogin_Click);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(181, 178);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(157, 41);
            this.exit.TabIndex = 4;
            this.exit.Text = "ВИЙТИ";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 231);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.oklogin);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button oklogin;
        private System.Windows.Forms.Button exit;
    }
}