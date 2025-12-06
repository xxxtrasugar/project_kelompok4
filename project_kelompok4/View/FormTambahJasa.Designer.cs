namespace project_kelompok4.View
{
    partial class FormTambahJasa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboSatuan = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.timeJam = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new RoundedButton();
            this.btnBatal = new RoundedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(828, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tambah Layanan Baru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Icon Emoji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ketersediaan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama Layanan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Deskripsi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Harga (Rp)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 549);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Satuan";
            // 
            // txtIcon
            // 
            this.txtIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIcon.Location = new System.Drawing.Point(11, 7);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(79, 30);
            this.txtIcon.TabIndex = 7;
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Penuh"});
            this.comboStatus.Location = new System.Drawing.Point(7, 4);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(323, 36);
            this.comboStatus.TabIndex = 8;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(11, 9);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(794, 27);
            this.txtNama.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtIcon);
            this.panel2.Location = new System.Drawing.Point(41, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 46);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboStatus);
            this.panel3.Location = new System.Drawing.Point(516, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 46);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtNama);
            this.panel4.Location = new System.Drawing.Point(40, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(818, 46);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtDeskripsi);
            this.panel5.Location = new System.Drawing.Point(40, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(818, 136);
            this.panel5.TabIndex = 12;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskripsi.Location = new System.Drawing.Point(11, 13);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(792, 104);
            this.txtDeskripsi.TabIndex = 9;
            // 
            // numHarga
            // 
            this.numHarga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHarga.Location = new System.Drawing.Point(3, 3);
            this.numHarga.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numHarga.Name = "numHarga";
            this.numHarga.Size = new System.Drawing.Size(433, 34);
            this.numHarga.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.numHarga);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 587);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(443, 45);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.comboSatuan);
            this.panel6.Location = new System.Drawing.Point(516, 587);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 46);
            this.panel6.TabIndex = 12;
            // 
            // comboSatuan
            // 
            this.comboSatuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSatuan.FormattingEnabled = true;
            this.comboSatuan.Items.AddRange(new object[] {
            "per hektar",
            "per jam",
            "per orang"});
            this.comboSatuan.Location = new System.Drawing.Point(6, 3);
            this.comboSatuan.Name = "comboSatuan";
            this.comboSatuan.Size = new System.Drawing.Size(323, 36);
            this.comboSatuan.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGreen;
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.timeJam);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.dateTanggal);
            this.panel7.Location = new System.Drawing.Point(40, 660);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(818, 137);
            this.panel7.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(515, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Jadwal ini akan ditampilkan kepada pelanggan dan tidak dapat diubah oleh mereka";
            // 
            // timeJam
            // 
            this.timeJam.CustomFormat = "HH:mm";
            this.timeJam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeJam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeJam.Location = new System.Drawing.Point(475, 62);
            this.timeJam.Name = "timeJam";
            this.timeJam.ShowUpDown = true;
            this.timeJam.Size = new System.Drawing.Size(330, 34);
            this.timeJam.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(473, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Jam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tanggal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tentukan Jadwal Layanan";
            // 
            // dateTanggal
            // 
            this.dateTanggal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTanggal.Location = new System.Drawing.Point(18, 61);
            this.dateTanggal.Name = "dateTanggal";
            this.dateTanggal.Size = new System.Drawing.Size(426, 34);
            this.dateTanggal.TabIndex = 0;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Green;
            this.btnSimpan.BorderRadius = 20;
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(487, 829);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(371, 41);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Tambah Layanan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BorderRadius = 20;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(40, 829);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(415, 41);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // FormTambahJasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 900);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahJasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTambahJasa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboSatuan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dateTanggal;
        private System.Windows.Forms.DateTimePicker timeJam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private RoundedButton btnBatal;
        private RoundedButton btnSimpan;
    }
}