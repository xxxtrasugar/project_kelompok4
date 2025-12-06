namespace project_kelompok4.View
{
    partial class FormPesanLayanan
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblNamaJasa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJadwalTanggal = new System.Windows.Forms.Label();
            this.lblJadwalJam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaPemesan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlamatPemesan = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnLanjut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboPembayaran = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesan Layanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jadwal yang Ditentukan Admin:";
            // 
            // lblNamaJasa
            // 
            this.lblNamaJasa.AutoSize = true;
            this.lblNamaJasa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaJasa.Location = new System.Drawing.Point(30, 61);
            this.lblNamaJasa.Name = "lblNamaJasa";
            this.lblNamaJasa.Size = new System.Drawing.Size(209, 31);
            this.lblNamaJasa.TabIndex = 2;
            this.lblNamaJasa.Text = "Pengolahan Tanah";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.lblJadwalJam);
            this.panel1.Controls.Add(this.lblJadwalTanggal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 118);
            this.panel1.TabIndex = 3;
            // 
            // lblJadwalTanggal
            // 
            this.lblJadwalTanggal.AutoSize = true;
            this.lblJadwalTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJadwalTanggal.Location = new System.Drawing.Point(18, 47);
            this.lblJadwalTanggal.Name = "lblJadwalTanggal";
            this.lblJadwalTanggal.Size = new System.Drawing.Size(239, 29);
            this.lblJadwalTanggal.TabIndex = 2;
            this.lblJadwalTanggal.Text = "Senin, 1 Desember 2025";
            // 
            // lblJadwalJam
            // 
            this.lblJadwalJam.AutoSize = true;
            this.lblJadwalJam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJadwalJam.Location = new System.Drawing.Point(18, 74);
            this.lblJadwalJam.Name = "lblJadwalJam";
            this.lblJadwalJam.Size = new System.Drawing.Size(134, 23);
            this.lblJadwalJam.TabIndex = 3;
            this.lblJadwalJam.Text = "Pukul 08:00 WIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama";
            // 
            // txtNamaPemesan
            // 
            this.txtNamaPemesan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaPemesan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPemesan.Location = new System.Drawing.Point(9, 11);
            this.txtNamaPemesan.Name = "txtNamaPemesan";
            this.txtNamaPemesan.Size = new System.Drawing.Size(488, 27);
            this.txtNamaPemesan.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNamaPemesan);
            this.panel2.Location = new System.Drawing.Point(37, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 51);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alamat";
            // 
            // txtAlamatPemesan
            // 
            this.txtAlamatPemesan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamatPemesan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamatPemesan.Location = new System.Drawing.Point(9, 11);
            this.txtAlamatPemesan.Name = "txtAlamatPemesan";
            this.txtAlamatPemesan.Size = new System.Drawing.Size(488, 27);
            this.txtAlamatPemesan.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtAlamatPemesan);
            this.panel3.Location = new System.Drawing.Point(36, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 51);
            this.panel3.TabIndex = 8;
            // 
            // txtNoHP
            // 
            this.txtNoHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoHP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoHP.Location = new System.Drawing.Point(9, 11);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(488, 27);
            this.txtNoHP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nomor HP";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtNoHP);
            this.panel4.Location = new System.Drawing.Point(38, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 51);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.lblTotalBayar);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(36, 549);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(516, 85);
            this.panel5.TabIndex = 4;
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBayar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBayar.Location = new System.Drawing.Point(269, 33);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(228, 29);
            this.lblTotalBayar.TabIndex = 2;
            this.lblTotalBayar.Text = "Rp 500.000";
            this.lblTotalBayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Pembayaran";
            // 
            // btnBatal
            // 
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(36, 727);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(203, 46);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnLanjut
            // 
            this.btnLanjut.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLanjut.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLanjut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanjut.ForeColor = System.Drawing.Color.White;
            this.btnLanjut.Location = new System.Drawing.Point(258, 727);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(294, 46);
            this.btnLanjut.TabIndex = 12;
            this.btnLanjut.Text = "Lanjutkan ke Pembayaran";
            this.btnLanjut.UseVisualStyleBackColor = false;
            this.btnLanjut.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Metode Pembayaran";
            // 
            // comboPembayaran
            // 
            this.comboPembayaran.FormattingEnabled = true;
            this.comboPembayaran.Location = new System.Drawing.Point(258, 649);
            this.comboPembayaran.Name = "comboPembayaran";
            this.comboPembayaran.Size = new System.Drawing.Size(294, 24);
            this.comboPembayaran.TabIndex = 14;
            // 
            // FormPesanLayanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 817);
            this.Controls.Add(this.comboPembayaran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLanjut);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNamaJasa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPesanLayanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPesanLayanan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNamaJasa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJadwalTanggal;
        private System.Windows.Forms.Label lblJadwalJam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPemesan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlamatPemesan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnLanjut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboPembayaran;
    }
}