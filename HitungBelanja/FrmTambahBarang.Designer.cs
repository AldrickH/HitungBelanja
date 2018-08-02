namespace HitungBelanja
{
    partial class FrmTambahBarang
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
            this.lblKode = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(89, 70);
            this.lblKode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(41, 17);
            this.lblKode.TabIndex = 0;
            this.lblKode.Text = "Kode";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(89, 122);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(45, 17);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(89, 172);
            this.lblJumlah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(53, 17);
            this.lblJumlah.TabIndex = 2;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(89, 226);
            this.lblHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(47, 17);
            this.lblHarga.TabIndex = 3;
            this.lblHarga.Text = "Harga";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(215, 70);
            this.txtKodeBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(309, 22);
            this.txtKodeBarang.TabIndex = 4;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(215, 122);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(309, 22);
            this.txtNamaBarang.TabIndex = 5;
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.Location = new System.Drawing.Point(215, 172);
            this.txtJumlahBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(309, 22);
            this.txtJumlahBarang.TabIndex = 6;
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.Location = new System.Drawing.Point(215, 226);
            this.txtHargaBarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.Size = new System.Drawing.Size(309, 22);
            this.txtHargaBarang.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Location = new System.Drawing.Point(317, 287);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 29);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatal.Location = new System.Drawing.Point(431, 287);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 29);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // FrmTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 376);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHargaBarang);
            this.Controls.Add(this.txtJumlahBarang);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblKode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTambahBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTambahBarang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}