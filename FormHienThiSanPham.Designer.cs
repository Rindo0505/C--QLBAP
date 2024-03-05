namespace QuanLyBanSach
{
    partial class FormHienThiSanPham
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
            groupBox1 = new GroupBox();
            btntimkiem = new Button();
            btnanh = new Button();
            ptbanh = new PictureBox();
            Cbbmaloai = new ComboBox();
            sanPhambeanBindingSource1 = new BindingSource(components);
            txtgiaban = new TextBox();
            txttimkiem = new TextBox();
            txtten = new TextBox();
            txtma = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btntrove = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            dgvhang = new DataGridView();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anhSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaBanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maLoaiSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sanPhambeanBindingSource2 = new BindingSource(components);
            sanPhambeanBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btntimkiem);
            groupBox1.Controls.Add(btnanh);
            groupBox1.Controls.Add(ptbanh);
            groupBox1.Controls.Add(Cbbmaloai);
            groupBox1.Controls.Add(txtgiaban);
            groupBox1.Controls.Add(txttimkiem);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(txtma);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1373, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(857, 40);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(112, 34);
            btntimkiem.TabIndex = 4;
            btntimkiem.Text = "Tìm Kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btnanh
            // 
            btnanh.BackColor = Color.White;
            btnanh.Location = new Point(359, 104);
            btnanh.Name = "btnanh";
            btnanh.Size = new Size(112, 34);
            btnanh.TabIndex = 4;
            btnanh.Text = "Anh";
            btnanh.UseVisualStyleBackColor = false;
            // 
            // ptbanh
            // 
            ptbanh.Location = new Point(516, 91);
            ptbanh.Name = "ptbanh";
            ptbanh.Size = new Size(192, 125);
            ptbanh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbanh.TabIndex = 3;
            ptbanh.TabStop = false;
            ptbanh.Click += ptbanh_Click;
            // 
            // Cbbmaloai
            // 
            Cbbmaloai.DataSource = sanPhambeanBindingSource1;
            Cbbmaloai.FormattingEnabled = true;
            Cbbmaloai.Location = new Point(516, 42);
            Cbbmaloai.Name = "Cbbmaloai";
            Cbbmaloai.Size = new Size(300, 33);
            Cbbmaloai.TabIndex = 2;
            // 
            // sanPhambeanBindingSource1
            // 
            sanPhambeanBindingSource1.DataSource = typeof(bean.SanPhambean);
            // 
            // txtgiaban
            // 
            txtgiaban.Location = new Point(126, 168);
            txtgiaban.Name = "txtgiaban";
            txtgiaban.Size = new Size(215, 31);
            txtgiaban.TabIndex = 1;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(1011, 40);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(265, 31);
            txttimkiem.TabIndex = 1;
            txttimkiem.TextChanged += txtten_TextChanged;
            // 
            // txtten
            // 
            txtten.Location = new Point(126, 101);
            txtten.Name = "txtten";
            txtten.Size = new Size(215, 31);
            txtten.TabIndex = 1;
            txtten.TextChanged += txtten_TextChanged;
            // 
            // txtma
            // 
            txtma.Location = new Point(126, 37);
            txtma.Name = "txtma";
            txtma.Size = new Size(215, 31);
            txtma.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 42);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 0;
            label4.Text = "Mã loại sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 0;
            label3.Text = "Giá Bán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 37);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btntrove);
            groupBox2.Controls.Add(btnxoa);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(btnthem);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 500);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1373, 60);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btntrove
            // 
            btntrove.Location = new Point(979, 20);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(112, 34);
            btntrove.TabIndex = 0;
            btntrove.Text = "Trở về";
            btntrove.UseVisualStyleBackColor = true;
            btntrove.Click += btntrove_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(669, 20);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(112, 34);
            btnxoa.TabIndex = 0;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(371, 20);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(112, 34);
            btnsua.TabIndex = 0;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(113, 20);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(112, 34);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // dgvhang
            // 
            dgvhang.AutoGenerateColumns = false;
            dgvhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhang.Columns.AddRange(new DataGridViewColumn[] { maSanPhamDataGridViewTextBoxColumn, tenSanPhamDataGridViewTextBoxColumn, anhSanPhamDataGridViewTextBoxColumn, giaBanDataGridViewTextBoxColumn, maLoaiSanPhamDataGridViewTextBoxColumn });
            dgvhang.DataSource = sanPhambeanBindingSource2;
            dgvhang.Dock = DockStyle.Fill;
            dgvhang.Location = new Point(0, 237);
            dgvhang.Name = "dgvhang";
            dgvhang.RowHeadersWidth = 62;
            dgvhang.RowTemplate.Height = 33;
            dgvhang.Size = new Size(1373, 263);
            dgvhang.TabIndex = 2;
            dgvhang.CellClick += dgvhang_CellClick;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            maSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
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
            anhSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            anhSanPhamDataGridViewTextBoxColumn.DataPropertyName = "AnhSanPham";
            anhSanPhamDataGridViewTextBoxColumn.HeaderText = "Ảnh Sản Phẩm";
            anhSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            anhSanPhamDataGridViewTextBoxColumn.Name = "anhSanPhamDataGridViewTextBoxColumn";
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            giaBanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            giaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            giaBanDataGridViewTextBoxColumn.MinimumWidth = 8;
            giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            // 
            // maLoaiSanPhamDataGridViewTextBoxColumn
            // 
            maLoaiSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maLoaiSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSanPham";
            maLoaiSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã Loại Sản Phẩm";
            maLoaiSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            maLoaiSanPhamDataGridViewTextBoxColumn.Name = "maLoaiSanPhamDataGridViewTextBoxColumn";
            // 
            // sanPhambeanBindingSource2
            // 
            sanPhambeanBindingSource2.DataSource = typeof(bean.SanPhambean);
            // 
            // sanPhambeanBindingSource
            // 
            sanPhambeanBindingSource.DataSource = typeof(bean.SanPhambean);
            // 
            // FormHienThiSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 560);
            Controls.Add(dgvhang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormHienThiSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHienThiSanPham";
            Load += FormHienThiSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhang).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhambeanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvhang;
        private ComboBox Cbbmaloai;
        private TextBox txtgiaban;
        private TextBox txtten;
        private TextBox txtma;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox ptbanh;
        private Button btnanh;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private BindingSource sanPhambeanBindingSource1;
        private BindingSource sanPhambeanBindingSource;
        private Button btntrove;
        private Button btntimkiem;
        private TextBox txttimkiem;
        private BindingSource sanPhambeanBindingSource2;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anhSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maLoaiSanPhamDataGridViewTextBoxColumn;
    }
}