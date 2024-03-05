namespace QuanLyBanSach
{
    partial class FormBanHang
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            dgvbang1 = new DataGridView();
            tenSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anhSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaBanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sanPhambeanBindingSource = new BindingSource(components);
            ptbanh = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txttensp = new TextBox();
            txttimkiem = new TextBox();
            label3 = new Label();
            txtgiaban = new TextBox();
            btngiohang = new Button();
            btnmua = new Button();
            label6 = new Label();
            txttongtien = new TextBox();
            TenSanPham = new DataGridViewTextBoxColumn();
            AnhSanPham = new DataGridViewTextBoxColumn();
            giaban = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            dgvbang2 = new DataGridView();
            hhaha = new DataGridViewTextBoxColumn();
            btntimkiem = new Button();
            btntrove = new Button();
            TenSP = new DataGridViewTextBoxColumn();
            anh = new DataGridViewTextBoxColumn();
            gb = new DataGridViewTextBoxColumn();
            SLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            update = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvbang1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvbang2).BeginInit();
            SuspendLayout();
            // 
            // dgvbang1
            // 
            dgvbang1.AutoGenerateColumns = false;
            dgvbang1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbang1.Columns.AddRange(new DataGridViewColumn[] { tenSanPhamDataGridViewTextBoxColumn, anhSanPhamDataGridViewTextBoxColumn, giaBanDataGridViewTextBoxColumn });
            dgvbang1.DataSource = sanPhambeanBindingSource;
            dgvbang1.Location = new Point(-6, 174);
            dgvbang1.Name = "dgvbang1";
            dgvbang1.RowHeadersWidth = 62;
            dgvbang1.RowTemplate.Height = 33;
            dgvbang1.Size = new Size(516, 311);
            dgvbang1.TabIndex = 0;
            dgvbang1.CellClick += dgvbang1_CellClick;
            dgvbang1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            tenSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            tenSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            // 
            // anhSanPhamDataGridViewTextBoxColumn
            // 
            anhSanPhamDataGridViewTextBoxColumn.DataPropertyName = "AnhSanPham";
            anhSanPhamDataGridViewTextBoxColumn.HeaderText = "Ảnh Sản Phẩm";
            anhSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            anhSanPhamDataGridViewTextBoxColumn.Name = "anhSanPhamDataGridViewTextBoxColumn";
            anhSanPhamDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            anhSanPhamDataGridViewTextBoxColumn.Visible = false;
            anhSanPhamDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            giaBanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            giaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            giaBanDataGridViewTextBoxColumn.MinimumWidth = 8;
            giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // sanPhambeanBindingSource
            // 
            sanPhambeanBindingSource.DataSource = typeof(bean.SanPhambean);
            // 
            // ptbanh
            // 
            ptbanh.Location = new Point(350, 15);
            ptbanh.Name = "ptbanh";
            ptbanh.Size = new Size(174, 138);
            ptbanh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbanh.TabIndex = 1;
            ptbanh.TabStop = false;
            ptbanh.Click += ptbanh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Tên SP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 68);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Giá Bán";
            // 
            // txttensp
            // 
            txttensp.Location = new Point(94, 9);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(150, 31);
            txttensp.TabIndex = 3;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(885, 12);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(243, 31);
            txttimkiem.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 15);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "Ảnh";
            // 
            // txtgiaban
            // 
            txtgiaban.Location = new Point(94, 62);
            txtgiaban.Name = "txtgiaban";
            txtgiaban.Size = new Size(150, 31);
            txtgiaban.TabIndex = 3;
            // 
            // btngiohang
            // 
            btngiohang.BackColor = Color.FromArgb(255, 128, 0);
            btngiohang.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btngiohang.Location = new Point(972, 545);
            btngiohang.Name = "btngiohang";
            btngiohang.Size = new Size(190, 34);
            btngiohang.TabIndex = 4;
            btngiohang.Text = "Thêm vào giỏ hàng";
            btngiohang.UseVisualStyleBackColor = false;
            btngiohang.Click += btngiohang_Click;
            // 
            // btnmua
            // 
            btnmua.BackColor = Color.FromArgb(0, 192, 192);
            btnmua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnmua.Location = new Point(1245, 545);
            btnmua.Name = "btnmua";
            btnmua.Size = new Size(112, 34);
            btnmua.TabIndex = 4;
            btnmua.Text = "Mua hàng";
            btnmua.UseVisualStyleBackColor = false;
            btnmua.Click += btnmua_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1067, 497);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 2;
            label6.Text = "Tổng Tiền:";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(1178, 494);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(227, 31);
            txttongtien.TabIndex = 5;
            // 
            // TenSanPham
            // 
            TenSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // AnhSanPham
            // 
            AnhSanPham.DataPropertyName = "AnhSanPham";
            AnhSanPham.HeaderText = "Ảnh Sản Phẩm";
            AnhSanPham.MinimumWidth = 8;
            AnhSanPham.Name = "AnhSanPham";
            AnhSanPham.Visible = false;
            AnhSanPham.Width = 150;
            // 
            // giaban
            // 
            giaban.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            giaban.HeaderText = "Giá Bán";
            giaban.MinimumWidth = 8;
            giaban.Name = "giaban";
            // 
            // soluong
            // 
            soluong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soluong.HeaderText = "Số Lượng";
            soluong.MinimumWidth = 8;
            soluong.Name = "soluong";
            // 
            // dgvbang2
            // 
            dgvbang2.AllowUserToAddRows = false;
            dgvbang2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbang2.Columns.AddRange(new DataGridViewColumn[] { TenSP, anh, gb, SLuong, ThanhTien, update, delete });
            dgvbang2.Location = new Point(511, 176);
            dgvbang2.Name = "dgvbang2";
            dgvbang2.RowHeadersWidth = 62;
            dgvbang2.RowTemplate.Height = 33;
            dgvbang2.Size = new Size(1011, 311);
            dgvbang2.TabIndex = 6;
            dgvbang2.CellClick += dgvbang2_CellClick_1;
            // 
            // hhaha
            // 
            hhaha.HeaderText = "Tên Sản Phẩm";
            hhaha.MinimumWidth = 8;
            hhaha.Name = "hhaha";
            hhaha.Width = 150;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(684, 13);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(112, 34);
            btntimkiem.TabIndex = 7;
            btntimkiem.Text = "Tìm Kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btntrove
            // 
            btntrove.BackColor = Color.FromArgb(128, 255, 128);
            btntrove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btntrove.Location = new Point(53, 545);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(122, 35);
            btntrove.TabIndex = 8;
            btntrove.Text = "Trở Về";
            btntrove.UseVisualStyleBackColor = false;
            btntrove.Click += btntrove_Click;
            // 
            // TenSP
            // 
            TenSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TenSP.HeaderText = "Tên Sản Phẩm";
            TenSP.MinimumWidth = 8;
            TenSP.Name = "TenSP";
            TenSP.Width = 158;
            // 
            // anh
            // 
            anh.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            anh.HeaderText = "Ảnh Sản Phẩm";
            anh.MinimumWidth = 8;
            anh.Name = "anh";
            anh.Width = 164;
            // 
            // gb
            // 
            gb.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gb.HeaderText = "Giá Bán";
            gb.MinimumWidth = 8;
            gb.Name = "gb";
            gb.Width = 107;
            // 
            // SLuong
            // 
            SLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SLuong.HeaderText = "Số Lượng";
            SLuong.MinimumWidth = 8;
            SLuong.Name = "SLuong";
            SLuong.Width = 125;
            // 
            // ThanhTien
            // 
            ThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 8;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 133;
            // 
            // update
            // 
            update.HeaderText = "UpDate";
            update.Image = (Image)resources.GetObject("update.Image");
            update.ImageLayout = DataGridViewImageCellLayout.Zoom;
            update.MinimumWidth = 8;
            update.Name = "update";
            update.ReadOnly = true;
            update.Resizable = DataGridViewTriState.True;
            update.SortMode = DataGridViewColumnSortMode.Automatic;
            update.Width = 150;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            delete.HeaderText = "Delete";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Width = 98;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1520, 591);
            Controls.Add(btntrove);
            Controls.Add(btntimkiem);
            Controls.Add(dgvbang2);
            Controls.Add(txttongtien);
            Controls.Add(btnmua);
            Controls.Add(btngiohang);
            Controls.Add(txttimkiem);
            Controls.Add(txtgiaban);
            Controls.Add(txttensp);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ptbanh);
            Controls.Add(dgvbang1);
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBanHang";
            Load += FormBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbang1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvbang2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvbang1;
        private BindingSource sanPhambeanBindingSource;
        private DataGridViewTextBoxColumn Anhsp;
        private PictureBox ptbanh;
        private Label label1;
        private Label label2;
        private TextBox txttensp;
        private TextBox txttimkiem;
        private Label label3;
        private TextBox txtgiaban;
        private Button btngiohang;
        private Button btnmua;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anhSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private Label label6;
        private TextBox txttongtien;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn AnhSanPham;
        private DataGridViewTextBoxColumn giaban;
        private DataGridViewTextBoxColumn soluong;
        private DataGridView dgvbang2;
        private DataGridViewTextBoxColumn hhaha;
        private DataGridViewTextBoxColumn AnhSP;
        private DataGridViewTextBoxColumn Gban;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn TT;
        private DataGridViewImageColumn sua;
        private DataGridViewImageColumn xoa;
        private Button btntimkiem;
        private Button btntrove;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn anh;
        private DataGridViewTextBoxColumn gb;
        private DataGridViewTextBoxColumn SLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewImageColumn update;
        private DataGridViewImageColumn delete;
    }
}