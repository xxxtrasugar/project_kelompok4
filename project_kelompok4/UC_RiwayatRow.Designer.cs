namespace project_kelompok4.View
{
    partial class UC_RiwayatRow
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPelanggan = new System.Windows.Forms.Label();
            this.lblLayanan = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPembayaran = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(44, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 28);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "#1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPelanggan
            // 
            this.lblPelanggan.AutoSize = true;
            this.lblPelanggan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelanggan.Location = new System.Drawing.Point(95, 27);
            this.lblPelanggan.Name = "lblPelanggan";
            this.lblPelanggan.Size = new System.Drawing.Size(162, 28);
            this.lblPelanggan.TabIndex = 1;
            this.lblPelanggan.Text = "Pak Budi Santoso";
            // 
            // lblLayanan
            // 
            this.lblLayanan.AutoSize = true;
            this.lblLayanan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayanan.Location = new System.Drawing.Point(308, 36);
            this.lblLayanan.Name = "lblLayanan";
            this.lblLayanan.Size = new System.Drawing.Size(169, 28);
            this.lblLayanan.TabIndex = 3;
            this.lblLayanan.Text = "Pengolahan Tanah";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(525, 36);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(116, 28);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "20/11/2025";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(700, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(2);
            this.lblStatus.Size = new System.Drawing.Size(117, 32);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Selesai";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPembayaran
            // 
            this.lblPembayaran.AutoSize = true;
            this.lblPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPembayaran.Location = new System.Drawing.Point(892, 36);
            this.lblPembayaran.Name = "lblPembayaran";
            this.lblPembayaran.Size = new System.Drawing.Size(95, 28);
            this.lblPembayaran.TabIndex = 6;
            this.lblPembayaran.Text = "Bank BCA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1049, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 28);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Rp 1.000.000";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1237, 10);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // UC_RiwayatRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPembayaran);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblLayanan);
            this.Controls.Add(this.lblPelanggan);
            this.Controls.Add(this.lblID);
            this.Name = "UC_RiwayatRow";
            this.Size = new System.Drawing.Size(1237, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPelanggan;
        private System.Windows.Forms.Label lblLayanan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPembayaran;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
