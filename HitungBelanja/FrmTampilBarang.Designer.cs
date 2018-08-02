namespace HitungBelanja
{
    partial class FrmTampilBarang
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
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBayar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPajak = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvDataOrder = new System.Windows.Forms.DataGridView();
            this.clmKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblKode = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtKode1 = new System.Windows.Forms.TextBox();
            this.txtNama1 = new System.Windows.Forms.TextBox();
            this.txtHarga1 = new System.Windows.Forms.TextBox();
            this.lblKode1 = new System.Windows.Forms.Label();
            this.lblNama1 = new System.Windows.Forms.Label();
            this.txtJumlah1 = new System.Windows.Forms.TextBox();
            this.lblJumlah1 = new System.Windows.Forms.Label();
            this.lblHarga1 = new System.Windows.Forms.Label();
            this.dgvDataBarang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNamaAdmin = new System.Windows.Forms.Label();
            this.lblNamaAdminIsi = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tabData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabData
            // 
            this.tabData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabData.Controls.Add(this.tabPage1);
            this.tabData.Controls.Add(this.tabPage2);
            this.tabData.Location = new System.Drawing.Point(8, 55);
            this.tabData.Margin = new System.Windows.Forms.Padding(2);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1252, 1012);
            this.tabData.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBayar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.txtPajak);
            this.tabPage1.Controls.Add(this.txtDiscount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnOrder);
            this.tabPage1.Controls.Add(this.dgvDataOrder);
            this.tabPage1.Controls.Add(this.txtKode);
            this.tabPage1.Controls.Add(this.txtNama);
            this.tabPage1.Controls.Add(this.txtHarga);
            this.tabPage1.Controls.Add(this.lblKode);
            this.tabPage1.Controls.Add(this.lblNama);
            this.tabPage1.Controls.Add(this.txtJumlah);
            this.tabPage1.Controls.Add(this.lblJumlah);
            this.tabPage1.Controls.Add(this.lblHarga);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1244, 983);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar Pesan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(919, 866);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(152, 45);
            this.btnBayar.TabIndex = 31;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1064, 334);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 17);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "{ total }";
            // 
            // txtPajak
            // 
            this.txtPajak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPajak.Location = new System.Drawing.Point(241, 308);
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.Size = new System.Drawing.Size(173, 22);
            this.txtPajak.TabIndex = 29;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(241, 251);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(173, 22);
            this.txtDiscount.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pajak";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Discount";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Location = new System.Drawing.Point(887, 136);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(103, 29);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // dgvDataOrder
            // 
            this.dgvDataOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKode,
            this.clmNama,
            this.clmJumlah,
            this.clmHarga,
            this.clmDiscount,
            this.clmPajak,
            this.clmSubTotal});
            this.dgvDataOrder.Location = new System.Drawing.Point(29, 377);
            this.dgvDataOrder.Name = "dgvDataOrder";
            this.dgvDataOrder.RowTemplate.Height = 33;
            this.dgvDataOrder.Size = new System.Drawing.Size(1190, 426);
            this.dgvDataOrder.TabIndex = 16;
            // 
            // clmKode
            // 
            this.clmKode.HeaderText = "Kode";
            this.clmKode.Name = "clmKode";
            // 
            // clmNama
            // 
            this.clmNama.HeaderText = "Nama";
            this.clmNama.Name = "clmNama";
            // 
            // clmJumlah
            // 
            this.clmJumlah.HeaderText = "Jumlah";
            this.clmJumlah.Name = "clmJumlah";
            // 
            // clmHarga
            // 
            this.clmHarga.HeaderText = "Harga";
            this.clmHarga.Name = "clmHarga";
            // 
            // clmDiscount
            // 
            this.clmDiscount.HeaderText = "Discount";
            this.clmDiscount.Name = "clmDiscount";
            // 
            // clmPajak
            // 
            this.clmPajak.HeaderText = "Pajak";
            this.clmPajak.Name = "clmPajak";
            // 
            // clmSubTotal
            // 
            this.clmSubTotal.HeaderText = "SubTotal";
            this.clmSubTotal.Name = "clmSubTotal";
            // 
            // txtKode
            // 
            this.txtKode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKode.Location = new System.Drawing.Point(241, 23);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(466, 22);
            this.txtKode.TabIndex = 12;
            this.txtKode.Leave += new System.EventHandler(this.txtKode_Leave);
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(241, 79);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(466, 22);
            this.txtNama.TabIndex = 14;
            this.txtNama.TabStop = false;
            // 
            // txtHarga
            // 
            this.txtHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(241, 187);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(466, 22);
            this.txtHarga.TabIndex = 15;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(39, 23);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(41, 17);
            this.lblKode.TabIndex = 8;
            this.lblKode.Text = "Kode";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(39, 79);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(45, 17);
            this.lblNama.TabIndex = 9;
            this.lblNama.Text = "Nama";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlah.Location = new System.Drawing.Point(241, 136);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(466, 22);
            this.txtJumlah.TabIndex = 13;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(39, 136);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(53, 17);
            this.lblJumlah.TabIndex = 10;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(39, 193);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(47, 17);
            this.lblHarga.TabIndex = 11;
            this.lblHarga.Text = "Harga";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCari);
            this.tabPage2.Controls.Add(this.txtKode1);
            this.tabPage2.Controls.Add(this.txtNama1);
            this.tabPage2.Controls.Add(this.txtHarga1);
            this.tabPage2.Controls.Add(this.lblKode1);
            this.tabPage2.Controls.Add(this.lblNama1);
            this.tabPage2.Controls.Add(this.txtJumlah1);
            this.tabPage2.Controls.Add(this.lblJumlah1);
            this.tabPage2.Controls.Add(this.lblHarga1);
            this.tabPage2.Controls.Add(this.dgvDataBarang);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1244, 983);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Daftar Barang";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCari.Location = new System.Drawing.Point(995, 108);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(166, 55);
            this.btnCari.TabIndex = 26;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // txtKode1
            // 
            this.txtKode1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKode1.Location = new System.Drawing.Point(169, 52);
            this.txtKode1.Name = "txtKode1";
            this.txtKode1.Size = new System.Drawing.Size(781, 22);
            this.txtKode1.TabIndex = 22;
            // 
            // txtNama1
            // 
            this.txtNama1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama1.Location = new System.Drawing.Point(169, 108);
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(781, 22);
            this.txtNama1.TabIndex = 24;
            // 
            // txtHarga1
            // 
            this.txtHarga1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHarga1.Location = new System.Drawing.Point(169, 216);
            this.txtHarga1.Name = "txtHarga1";
            this.txtHarga1.Size = new System.Drawing.Size(781, 22);
            this.txtHarga1.TabIndex = 25;
            // 
            // lblKode1
            // 
            this.lblKode1.AutoSize = true;
            this.lblKode1.Location = new System.Drawing.Point(49, 52);
            this.lblKode1.Name = "lblKode1";
            this.lblKode1.Size = new System.Drawing.Size(41, 17);
            this.lblKode1.TabIndex = 18;
            this.lblKode1.Text = "Kode";
            // 
            // lblNama1
            // 
            this.lblNama1.AutoSize = true;
            this.lblNama1.Location = new System.Drawing.Point(49, 108);
            this.lblNama1.Name = "lblNama1";
            this.lblNama1.Size = new System.Drawing.Size(45, 17);
            this.lblNama1.TabIndex = 19;
            this.lblNama1.Text = "Nama";
            // 
            // txtJumlah1
            // 
            this.txtJumlah1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlah1.Location = new System.Drawing.Point(169, 165);
            this.txtJumlah1.Name = "txtJumlah1";
            this.txtJumlah1.Size = new System.Drawing.Size(781, 22);
            this.txtJumlah1.TabIndex = 23;
            // 
            // lblJumlah1
            // 
            this.lblJumlah1.AutoSize = true;
            this.lblJumlah1.Location = new System.Drawing.Point(49, 165);
            this.lblJumlah1.Name = "lblJumlah1";
            this.lblJumlah1.Size = new System.Drawing.Size(53, 17);
            this.lblJumlah1.TabIndex = 20;
            this.lblJumlah1.Text = "Jumlah";
            // 
            // lblHarga1
            // 
            this.lblHarga1.AutoSize = true;
            this.lblHarga1.Location = new System.Drawing.Point(49, 222);
            this.lblHarga1.Name = "lblHarga1";
            this.lblHarga1.Size = new System.Drawing.Size(47, 17);
            this.lblHarga1.TabIndex = 21;
            this.lblHarga1.Text = "Harga";
            // 
            // dgvDataBarang
            // 
            this.dgvDataBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDataBarang.Location = new System.Drawing.Point(25, 315);
            this.dgvDataBarang.Name = "dgvDataBarang";
            this.dgvDataBarang.RowTemplate.Height = 33;
            this.dgvDataBarang.Size = new System.Drawing.Size(1194, 632);
            this.dgvDataBarang.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Kode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Jumlah";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Harga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // lblNamaAdmin
            // 
            this.lblNamaAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaAdmin.AutoSize = true;
            this.lblNamaAdmin.Location = new System.Drawing.Point(1010, 47);
            this.lblNamaAdmin.Name = "lblNamaAdmin";
            this.lblNamaAdmin.Size = new System.Drawing.Size(45, 17);
            this.lblNamaAdmin.TabIndex = 1;
            this.lblNamaAdmin.Text = "Nama";
            // 
            // lblNamaAdminIsi
            // 
            this.lblNamaAdminIsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaAdminIsi.AutoSize = true;
            this.lblNamaAdminIsi.Location = new System.Drawing.Point(1084, 47);
            this.lblNamaAdminIsi.Name = "lblNamaAdminIsi";
            this.lblNamaAdminIsi.Size = new System.Drawing.Size(103, 17);
            this.lblNamaAdminIsi.TabIndex = 2;
            this.lblNamaAdminIsi.Text = "{ nama admin }";
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambah.Location = new System.Drawing.Point(778, 39);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(212, 41);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah Barang";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // FrmTampilBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 1055);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblNamaAdminIsi);
            this.Controls.Add(this.lblNamaAdmin);
            this.Controls.Add(this.tabData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTampilBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tampil Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTampilBarang_Load);
            this.tabData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOrder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvDataOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHarga;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.DataGridView dgvDataBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblNamaAdmin;
        private System.Windows.Forms.Label lblNamaAdminIsi;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtKode1;
        private System.Windows.Forms.TextBox txtNama1;
        private System.Windows.Forms.TextBox txtHarga1;
        private System.Windows.Forms.Label lblKode1;
        private System.Windows.Forms.Label lblNama1;
        private System.Windows.Forms.TextBox txtJumlah1;
        private System.Windows.Forms.Label lblJumlah1;
        private System.Windows.Forms.Label lblHarga1;
        private System.Windows.Forms.TextBox txtPajak;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPajak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label lblTotal;
    }
}

