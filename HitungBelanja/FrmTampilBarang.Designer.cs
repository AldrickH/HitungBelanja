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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPajak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvDataOrder = new System.Windows.Forms.DataGridView();
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
            this.clmKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabData.Location = new System.Drawing.Point(5, 54);
            this.tabData.Margin = new System.Windows.Forms.Padding(1);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1198, 504);
            this.tabData.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnBayar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.txtPajak);
            this.tabPage1.Controls.Add(this.label1);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1190, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar Pesan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(156, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 32);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kode barang tidak terdefinisi";
            this.label3.Visible = false;
            // 
            // btnBayar
            // 
            this.btnBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBayar.Location = new System.Drawing.Point(962, 377);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(217, 66);
            this.btnBayar.TabIndex = 31;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1017, 2);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(162, 45);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "{ total }";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPajak
            // 
            this.txtPajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPajak.Location = new System.Drawing.Point(162, 303);
            this.txtPajak.Margin = new System.Windows.Forms.Padding(2);
            this.txtPajak.MaxLength = 5;
            this.txtPajak.Multiline = true;
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.Size = new System.Drawing.Size(281, 41);
            this.txtPajak.TabIndex = 29;
            this.txtPajak.TextChanged += new System.EventHandler(this.txtPajak_TextChanged);
            this.txtPajak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngka_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pajak";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(232, 379);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(269, 75);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgvDataOrder
            // 
            this.dgvDataOrder.AllowUserToAddRows = false;
            this.dgvDataOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKode,
            this.clmNama,
            this.clmJumlah,
            this.clmHarga,
            this.clmPajak,
            this.clmSubTotal});
            this.dgvDataOrder.Location = new System.Drawing.Point(630, 50);
            this.dgvDataOrder.Name = "dgvDataOrder";
            this.dgvDataOrder.ReadOnly = true;
            this.dgvDataOrder.RowHeadersVisible = false;
            this.dgvDataOrder.RowTemplate.Height = 33;
            this.dgvDataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataOrder.Size = new System.Drawing.Size(549, 322);
            this.dgvDataOrder.TabIndex = 16;
            this.dgvDataOrder.Resize += new System.EventHandler(this.dgvDataOrder_Resize);
            // 
            // txtKode
            // 
            this.txtKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKode.Location = new System.Drawing.Point(162, 81);
            this.txtKode.Multiline = true;
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(281, 41);
            this.txtKode.TabIndex = 12;
            this.txtKode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngka_KeyPress);
            this.txtKode.Leave += new System.EventHandler(this.txtKode_Leave);
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(162, 133);
            this.txtNama.Margin = new System.Windows.Forms.Padding(2);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(457, 41);
            this.txtNama.TabIndex = 14;
            this.txtNama.TabStop = false;
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(162, 248);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(2);
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(358, 41);
            this.txtHarga.TabIndex = 15;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKode.Location = new System.Drawing.Point(27, 82);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(93, 38);
            this.lblKode.TabIndex = 8;
            this.lblKode.Text = "Kode";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(27, 134);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(104, 38);
            this.lblNama.TabIndex = 9;
            this.lblNama.Text = "Nama";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(162, 191);
            this.txtJumlah.Multiline = true;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(281, 41);
            this.txtJumlah.TabIndex = 13;
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngka_KeyPress);
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(25, 194);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(122, 38);
            this.lblJumlah.TabIndex = 10;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(27, 248);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(106, 38);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1190, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Daftar Barang";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCari.Location = new System.Drawing.Point(1029, 83);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(118, 40);
            this.btnCari.TabIndex = 26;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // txtKode1
            // 
            this.txtKode1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKode1.Location = new System.Drawing.Point(169, 26);
            this.txtKode1.Name = "txtKode1";
            this.txtKode1.Size = new System.Drawing.Size(849, 38);
            this.txtKode1.TabIndex = 22;
            // 
            // txtNama1
            // 
            this.txtNama1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama1.Location = new System.Drawing.Point(169, 72);
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(849, 38);
            this.txtNama1.TabIndex = 24;
            // 
            // txtHarga1
            // 
            this.txtHarga1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHarga1.Location = new System.Drawing.Point(169, 160);
            this.txtHarga1.Name = "txtHarga1";
            this.txtHarga1.Size = new System.Drawing.Size(849, 38);
            this.txtHarga1.TabIndex = 25;
            // 
            // lblKode1
            // 
            this.lblKode1.AutoSize = true;
            this.lblKode1.Location = new System.Drawing.Point(49, 26);
            this.lblKode1.Name = "lblKode1";
            this.lblKode1.Size = new System.Drawing.Size(82, 32);
            this.lblKode1.TabIndex = 18;
            this.lblKode1.Text = "Kode";
            // 
            // lblNama1
            // 
            this.lblNama1.AutoSize = true;
            this.lblNama1.Location = new System.Drawing.Point(49, 72);
            this.lblNama1.Name = "lblNama1";
            this.lblNama1.Size = new System.Drawing.Size(90, 32);
            this.lblNama1.TabIndex = 19;
            this.lblNama1.Text = "Nama";
            // 
            // txtJumlah1
            // 
            this.txtJumlah1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlah1.Location = new System.Drawing.Point(169, 116);
            this.txtJumlah1.Name = "txtJumlah1";
            this.txtJumlah1.Size = new System.Drawing.Size(849, 38);
            this.txtJumlah1.TabIndex = 23;
            // 
            // lblJumlah1
            // 
            this.lblJumlah1.AutoSize = true;
            this.lblJumlah1.Location = new System.Drawing.Point(49, 116);
            this.lblJumlah1.Name = "lblJumlah1";
            this.lblJumlah1.Size = new System.Drawing.Size(107, 32);
            this.lblJumlah1.TabIndex = 20;
            this.lblJumlah1.Text = "Jumlah";
            // 
            // lblHarga1
            // 
            this.lblHarga1.AutoSize = true;
            this.lblHarga1.Location = new System.Drawing.Point(49, 166);
            this.lblHarga1.Name = "lblHarga1";
            this.lblHarga1.Size = new System.Drawing.Size(92, 32);
            this.lblHarga1.TabIndex = 21;
            this.lblHarga1.Text = "Harga";
            // 
            // dgvDataBarang
            // 
            this.dgvDataBarang.AllowUserToAddRows = false;
            this.dgvDataBarang.AllowUserToDeleteRows = false;
            this.dgvDataBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDataBarang.Location = new System.Drawing.Point(4, 203);
            this.dgvDataBarang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataBarang.Name = "dgvDataBarang";
            this.dgvDataBarang.ReadOnly = true;
            this.dgvDataBarang.RowHeadersVisible = false;
            this.dgvDataBarang.RowTemplate.Height = 33;
            this.dgvDataBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataBarang.Size = new System.Drawing.Size(1182, 244);
            this.dgvDataBarang.TabIndex = 17;
            this.dgvDataBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBarang_CellDoubleClick);
            this.dgvDataBarang.Resize += new System.EventHandler(this.dgvDataBarang_Resize);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Kode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Jumlah";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Harga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblNamaAdmin
            // 
            this.lblNamaAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaAdmin.AutoSize = true;
            this.lblNamaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaAdmin.Location = new System.Drawing.Point(869, 20);
            this.lblNamaAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaAdmin.Name = "lblNamaAdmin";
            this.lblNamaAdmin.Size = new System.Drawing.Size(90, 32);
            this.lblNamaAdmin.TabIndex = 1;
            this.lblNamaAdmin.Text = "Nama";
            // 
            // lblNamaAdminIsi
            // 
            this.lblNamaAdminIsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaAdminIsi.AutoSize = true;
            this.lblNamaAdminIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaAdminIsi.Location = new System.Drawing.Point(992, 20);
            this.lblNamaAdminIsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaAdminIsi.Name = "lblNamaAdminIsi";
            this.lblNamaAdminIsi.Size = new System.Drawing.Size(203, 32);
            this.lblNamaAdminIsi.TabIndex = 2;
            this.lblNamaAdminIsi.Text = "{ nama admin }";
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(680, 11);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(132, 49);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah Barang";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // clmKode
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmKode.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmKode.HeaderText = "Kode";
            this.clmKode.Name = "clmKode";
            this.clmKode.ReadOnly = true;
            // 
            // clmNama
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmNama.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmNama.HeaderText = "Nama";
            this.clmNama.Name = "clmNama";
            this.clmNama.ReadOnly = true;
            // 
            // clmJumlah
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmJumlah.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmJumlah.HeaderText = "Jumlah";
            this.clmJumlah.Name = "clmJumlah";
            this.clmJumlah.ReadOnly = true;
            // 
            // clmHarga
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmHarga.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmHarga.HeaderText = "Harga";
            this.clmHarga.Name = "clmHarga";
            this.clmHarga.ReadOnly = true;
            // 
            // clmPajak
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmPajak.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmPajak.HeaderText = "Pajak";
            this.clmPajak.Name = "clmPajak";
            this.clmPajak.ReadOnly = true;
            this.clmPajak.Width = 50;
            // 
            // clmSubTotal
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSubTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmSubTotal.HeaderText = "SubTotal";
            this.clmSubTotal.Name = "clmSubTotal";
            this.clmSubTotal.ReadOnly = true;
            this.clmSubTotal.Width = 50;
            // 
            // FrmTampilBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 568);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblNamaAdminIsi);
            this.Controls.Add(this.lblNamaAdmin);
            this.Controls.Add(this.tabData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPajak;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
    }
}

