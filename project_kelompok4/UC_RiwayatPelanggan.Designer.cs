namespace project_kelompok4.View
{
    partial class UC_RiwayatPelanggan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNamaJasa = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblPembayaran = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNamaJasa
            // 
            this.lblNamaJasa.AutoSize = true;
            this.lblNamaJasa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaJasa.Location = new System.Drawing.Point(42, 29);
            this.lblNamaJasa.Name = "lblNamaJasa";
            this.lblNamaJasa.Size = new System.Drawing.Size(184, 28);
            this.lblNamaJasa.TabIndex = 0;
            this.lblNamaJasa.Text = "Pengolahan Tanah";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(250, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(4);
            this.lblStatus.Size = new System.Drawing.Size(69, 31);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Selesai";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokasi.Location = new System.Drawing.Point(43, 66);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(172, 20);
            this.lblLokasi.TabIndex = 2;
            this.lblLokasi.Text = "Desa Sukorambi, Jember";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(43, 86);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(169, 25);
            this.lblTanggal.TabIndex = 3;
            this.lblTanggal.Text = "20 November 2025";
            // 
            // lblPembayaran
            // 
            this.lblPembayaran.AutoSize = true;
            this.lblPembayaran.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPembayaran.Location = new System.Drawing.Point(43, 106);
            this.lblPembayaran.Name = "lblPembayaran";
            this.lblPembayaran.Size = new System.Drawing.Size(201, 25);
            this.lblPembayaran.TabIndex = 4;
            this.lblPembayaran.Text = "Pembayaran: Bank BCA";
            // 
            // lblHarga
            // 
            this.lblHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga.Location = new System.Drawing.Point(734, 51);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(230, 35);
            this.lblHarga.TabIndex = 5;
            this.lblHarga.Text = "Rp. 500.000";
            this.lblHarga.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 10);
            this.panel1.TabIndex = 6;
            // 
            // UC_RiwayatPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblPembayaran);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNamaJasa);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.Name = "UC_RiwayatPelanggan";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(1030, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaJasa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblPembayaran;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Panel panel1;
    }
}
