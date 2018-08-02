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
            this.btnBayar = new System.Windows.Forms.Button();
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
            this.tabData.Location = new System.Drawing.Point(12, 115);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1533, 933);
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
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1517, 886);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar Pesan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1379, 350);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 25);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "{ total }";
            // 
            // txtPajak
            // 
            this.txtPajak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPajak.Location = new System.Drawing.Point(257, 312);
            this.txtPajak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.Size = new System.Drawing.Size(258, 31);
            this.txtPajak.TabIndex = 29;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(257, 251);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(258, 31);
            this.txtDiscount.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pajak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Discount";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Location = new System.Drawing.Point(770, 111);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(154, 45);
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
            this.dgvDataOrder.Location = new System.Drawing.Point(54, 394);
            this.dgvDataOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDataOrder.Name = "dgvDataOrder";
            this.dgvDataOrder.RowTemplate.Height = 33;
            this.dgvDataOrder.Size = new System.Drawing.Size(1404, 385);
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
            this.txtKode.Location = new System.Drawing.Point(257, 36);
            this.txtKode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(478, 31);
            this.txtKode.TabIndex = 12;
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.Location = new System.Drawing.Point(257, 90);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(478, 31);
            this.txtNama.TabIndex = 14;
            // 
            // txtHarga
            // 
            this.txtHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHarga.Location = new System.Drawing.Point(257, 197);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(478, 31);
            this.txtHarga.TabIndex = 15;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(58, 36);
            this.lblKode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(62, 25);
            this.lblKode.TabIndex = 8;
            this.lblKode.Text = "Kode";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(58, 90);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(68, 25);
            this.lblNama.TabIndex = 9;
            this.lblNama.Text = "Nama";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlah.Location = new System.Drawing.Point(257, 143);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(478, 31);
            this.txtJumlah.TabIndex = 13;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(58, 143);
            this.lblJumlah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(81, 25);
            this.lblJumlah.TabIndex = 10;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(58, 207);
            this.lblHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(70, 25);
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
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1517, 886);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Daftar Barang";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCari.Location = new System.Drawing.Point(1155, 122);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(249, 65);
            this.btnCari.TabIndex = 26;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // txtKode1
            // 
            this.txtKode1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKode1.Location = new System.Drawing.Point(254, 41);
            this.txtKode1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKode1.Name = "txtKode1";
            this.txtKode1.Size = new System.Drawing.Size(825, 31);
            this.txtKode1.TabIndex = 22;
            // 
            // txtNama1
            // 
            this.txtNama1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama1.Location = new System.Drawing.Point(254, 113);
            this.txtNama1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(825, 31);
            this.txtNama1.TabIndex = 24;
            // 
            // txtHarga1
            // 
            this.txtHarga1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHarga1.Location = new System.Drawing.Point(254, 250);
            this.txtHarga1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga1.Name = "txtHarga1";
            this.txtHarga1.Size = new System.Drawing.Size(825, 31);
            this.txtHarga1.TabIndex = 25;
            // 
            // lblKode1
            // 
            this.lblKode1.AutoSize = true;
            this.lblKode1.Location = new System.Drawing.Point(74, 41);
            this.lblKode1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKode1.Name = "lblKode1";
            this.lblKode1.Size = new System.Drawing.Size(62, 25);
            this.lblKode1.TabIndex = 18;
            this.lblKode1.Text = "Kode";
            // 
            // lblNama1
            // 
            this.lblNama1.AutoSize = true;
            this.lblNama1.Location = new System.Drawing.Point(74, 113);
            this.lblNama1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama1.Name = "lblNama1";
            this.lblNama1.Size = new System.Drawing.Size(68, 25);
            this.lblNama1.TabIndex = 19;
            this.lblNama1.Text = "Nama";
            // 
            // txtJumlah1
            // 
            this.txtJumlah1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlah1.Location = new System.Drawing.Point(254, 181);
            this.txtJumlah1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJumlah1.Name = "txtJumlah1";
            this.txtJumlah1.Size = new System.Drawing.Size(825, 31);
            this.txtJumlah1.TabIndex = 23;
            // 
            // lblJumlah1
            // 
            this.lblJumlah1.AutoSize = true;
            this.lblJumlah1.Location = new System.Drawing.Point(74, 181);
            this.lblJumlah1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJumlah1.Name = "lblJumlah1";
            this.lblJumlah1.Size = new System.Drawing.Size(81, 25);
            this.lblJumlah1.TabIndex = 20;
            this.lblJumlah1.Text = "Jumlah";
            // 
            // lblHarga1
            // 
            this.lblHarga1.AutoSize = true;
            this.lblHarga1.Location = new System.Drawing.Point(74, 259);
            this.lblHarga1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHarga1.Name = "lblHarga1";
            this.lblHarga1.Size = new System.Drawing.Size(70, 25);
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
            this.dgvDataBarang.Location = new System.Drawing.Point(8, 337);
            this.dgvDataBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDataBarang.Name = "dgvDataBarang";
            this.dgvDataBarang.RowTemplate.Height = 33;
            this.dgvDataBarang.Size = new System.Drawing.Size(1494, 539);
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
            this.lblNamaAdmin.Location = new System.Drawing.Point(1245, 73);
            this.lblNamaAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaAdmin.Name = "lblNamaAdmin";
            this.lblNamaAdmin.Size = new System.Drawing.Size(68, 25);
            this.lblNamaAdmin.TabIndex = 1;
            this.lblNamaAdmin.Text = "Nama";
            // 
            // lblNamaAdminIsi
            // 
            this.lblNamaAdminIsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaAdminIsi.AutoSize = true;
            this.lblNamaAdminIsi.Location = new System.Drawing.Point(1353, 73);
            this.lblNamaAdminIsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaAdminIsi.Name = "lblNamaAdminIsi";
            this.lblNamaAdminIsi.Size = new System.Drawing.Size(155, 25);
            this.lblNamaAdminIsi.TabIndex = 2;
            this.lblNamaAdminIsi.Text = "{ nama admin }";
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambah.Location = new System.Drawing.Point(894, 53);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(318, 45);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah Barang";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBayar.Location = new System.Drawing.Point(1230, 806);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(192, 41);
            this.btnBayar.TabIndex = 31;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            // 
            // FrmTampilBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 1060);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblNamaAdminIsi);
            this.Controls.Add(this.lblNamaAdmin);
            this.Controls.Add(this.tabData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBayar;
    }
}

