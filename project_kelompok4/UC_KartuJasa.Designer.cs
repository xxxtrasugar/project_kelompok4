namespace project_kelompok4.View
{
    partial class UC_KartuJasa
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(13, 59);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(168, 25);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Pengolahan Tanah";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.LightGreen;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(284, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(1);
            this.lblStatus.Size = new System.Drawing.Size(59, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Tersedia";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskripsi.Location = new System.Drawing.Point(16, 84);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(275, 34);
            this.lblDeskripsi.TabIndex = 3;
            this.lblDeskripsi.Text = "Membajak, mencangkul, dan mempersiapkan \r\nlahan untuk masa tanam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblJadwal);
            this.panel1.Location = new System.Drawing.Point(21, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 68);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jadwal";
            // 
            // lblJadwal
            // 
            this.lblJadwal.AutoSize = true;
            this.lblJadwal.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJadwal.Location = new System.Drawing.Point(14, 32);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(117, 17);
            this.lblJadwal.TabIndex = 0;
            this.lblJadwal.Text = "1 Des 2025 • 08:00";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga.Location = new System.Drawing.Point(21, 207);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(152, 17);
            this.lblHarga.TabIndex = 5;
            this.lblHarga.Text = "Rp. 500.000 / per hektar";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightBlue;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Location = new System.Drawing.Point(21, 229);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.LightCoral;
            this.btnHapus.Location = new System.Drawing.Point(188, 228);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(157, 35);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_kelompok4.Properties.Resources.logo_garap;
            this.pictureBox1.Location = new System.Drawing.Point(16, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_KartuJasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Name = "UC_KartuJasa";
            this.Size = new System.Drawing.Size(370, 270);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
    }
}
