namespace project_kelompok4.View
{
    partial class FormLogin
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblDaftar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRoleAdmin = new RoundedButton();
            this.btnRolePelanggan = new RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.lblDaftar);
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.btnRoleAdmin);
            this.panelLogin.Controls.Add(this.btnRolePelanggan);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Location = new System.Drawing.Point(846, 403);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(500, 688);
            this.panelLogin.TabIndex = 0;
            // 
            // lblDaftar
            // 
            this.lblDaftar.AutoSize = true;
            this.lblDaftar.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDaftar.Location = new System.Drawing.Point(268, 603);
            this.lblDaftar.Name = "lblDaftar";
            this.lblDaftar.Size = new System.Drawing.Size(105, 17);
            this.lblDaftar.TabIndex = 12;
            this.lblDaftar.Text = "Daftar Sekarang";
            this.lblDaftar.Click += new System.EventHandler(this.lblDaftar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Belum punya akun?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(83, 522);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(330, 65);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Masuk";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(55, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 48);
            this.panel2.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(7, 13);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(336, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(55, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 48);
            this.panel1.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(7, 11);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(336, 23);
            this.txtUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Masuk ke akun GARAP anda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masuk Sebagai";
            // 
            // btnRoleAdmin
            // 
            this.btnRoleAdmin.BorderRadius = 20;
            this.btnRoleAdmin.Location = new System.Drawing.Point(242, 246);
            this.btnRoleAdmin.Name = "btnRoleAdmin";
            this.btnRoleAdmin.Size = new System.Drawing.Size(142, 45);
            this.btnRoleAdmin.TabIndex = 3;
            this.btnRoleAdmin.Text = "Admin";
            this.btnRoleAdmin.UseVisualStyleBackColor = true;
            this.btnRoleAdmin.Click += new System.EventHandler(this.btnRoleAdmin_Click);
            // 
            // btnRolePelanggan
            // 
            this.btnRolePelanggan.BorderRadius = 20;
            this.btnRolePelanggan.Location = new System.Drawing.Point(94, 246);
            this.btnRolePelanggan.Name = "btnRolePelanggan";
            this.btnRolePelanggan.Size = new System.Drawing.Size(142, 45);
            this.btnRolePelanggan.TabIndex = 2;
            this.btnRolePelanggan.Text = "Pelanggan";
            this.btnRolePelanggan.UseVisualStyleBackColor = true;
            this.btnRolePelanggan.Click += new System.EventHandler(this.btnRolePelanggan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selamat Datang Kembali";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_kelompok4.Properties.Resources.logo_garap;
            this.pictureBox1.Location = new System.Drawing.Point(193, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Resize += new System.EventHandler(this.FormLogin_Resize);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedButton btnRolePelanggan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RoundedButton btnRoleAdmin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private RoundedButton btnLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDaftar;
    }
}