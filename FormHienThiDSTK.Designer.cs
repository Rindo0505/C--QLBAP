namespace QuanLyBanSach
{
    partial class FormHienThiDSTK
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
            txtquyen = new TextBox();
            txtmanv = new TextBox();
            txtmk = new TextBox();
            txttendn = new TextBox();
            txtmatk = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btntrove = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            dgvbangtk = new DataGridView();
            maTaiKhoanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDangNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matKhauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quyenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taiKhoanbeanBindingSource2 = new BindingSource(components);
            taiKhoanbeanBindingSource = new BindingSource(components);
            taiKhoanbeanBindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbangtk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanbeanBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanbeanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanbeanBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtquyen);
            groupBox1.Controls.Add(txtmanv);
            groupBox1.Controls.Add(txtmk);
            groupBox1.Controls.Add(txttendn);
            groupBox1.Controls.Add(txtmatk);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1066, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtquyen
            // 
            txtquyen.Location = new Point(736, 76);
            txtquyen.Name = "txtquyen";
            txtquyen.Size = new Size(237, 34);
            txtquyen.TabIndex = 1;
            // 
            // txtmanv
            // 
            txtmanv.Location = new Point(736, 27);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(237, 34);
            txtmanv.TabIndex = 1;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(184, 123);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(237, 34);
            txtmk.TabIndex = 1;
            // 
            // txttendn
            // 
            txttendn.Location = new Point(184, 76);
            txttendn.Name = "txttendn";
            txttendn.Size = new Size(241, 34);
            txttendn.TabIndex = 1;
            // 
            // txtmatk
            // 
            txtmatk.Location = new Point(184, 27);
            txtmatk.Name = "txtmatk";
            txtmatk.Size = new Size(241, 34);
            txtmatk.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 76);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 0;
            label5.Text = "Quyền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 27);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 0;
            label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 126);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btntrove);
            groupBox2.Controls.Add(btnxoa);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(btnthem);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 406);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1066, 57);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btntrove
            // 
            btntrove.BackColor = Color.FromArgb(0, 192, 192);
            btntrove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btntrove.Location = new Point(659, 17);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(112, 34);
            btntrove.TabIndex = 0;
            btntrove.Text = "Trở Về";
            btntrove.UseVisualStyleBackColor = false;
            btntrove.Click += btntrove_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 255, 128);
            btnxoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoa.Location = new Point(505, 17);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(112, 34);
            btnxoa.TabIndex = 0;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 128, 0);
            btnsua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnsua.Location = new Point(344, 17);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(112, 34);
            btnsua.TabIndex = 0;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 128, 128);
            btnthem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.Location = new Point(184, 17);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(112, 34);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // dgvbangtk
            // 
            dgvbangtk.AllowUserToDeleteRows = false;
            dgvbangtk.AutoGenerateColumns = false;
            dgvbangtk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbangtk.Columns.AddRange(new DataGridViewColumn[] { maTaiKhoanDataGridViewTextBoxColumn, tenDangNhapDataGridViewTextBoxColumn, matKhauDataGridViewTextBoxColumn, maNhanVienDataGridViewTextBoxColumn, quyenDataGridViewTextBoxColumn });
            dgvbangtk.DataSource = taiKhoanbeanBindingSource2;
            dgvbangtk.Dock = DockStyle.Fill;
            dgvbangtk.Location = new Point(0, 164);
            dgvbangtk.Name = "dgvbangtk";
            dgvbangtk.RowHeadersWidth = 62;
            dgvbangtk.RowTemplate.Height = 33;
            dgvbangtk.Size = new Size(1066, 242);
            dgvbangtk.TabIndex = 2;
            dgvbangtk.CellClick += dgvbangtk_CellClick;
            // 
            // maTaiKhoanDataGridViewTextBoxColumn
            // 
            maTaiKhoanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "MaTaiKhoan";
            maTaiKhoanDataGridViewTextBoxColumn.HeaderText = "Mã Tài Khoản";
            maTaiKhoanDataGridViewTextBoxColumn.MinimumWidth = 8;
            maTaiKhoanDataGridViewTextBoxColumn.Name = "maTaiKhoanDataGridViewTextBoxColumn";
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            tenDangNhapDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên Đăng Nhập";
            tenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            matKhauDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            matKhauDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
            matKhauDataGridViewTextBoxColumn.MinimumWidth = 8;
            matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            maNhanVienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            // 
            // quyenDataGridViewTextBoxColumn
            // 
            quyenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quyenDataGridViewTextBoxColumn.DataPropertyName = "Quyen";
            quyenDataGridViewTextBoxColumn.HeaderText = "Quyền";
            quyenDataGridViewTextBoxColumn.MinimumWidth = 8;
            quyenDataGridViewTextBoxColumn.Name = "quyenDataGridViewTextBoxColumn";
            // 
            // taiKhoanbeanBindingSource2
            // 
            taiKhoanbeanBindingSource2.DataSource = typeof(bean.TaiKhoanbean);
            // 
            // taiKhoanbeanBindingSource
            // 
            taiKhoanbeanBindingSource.DataSource = typeof(bean.TaiKhoanbean);
            // 
            // taiKhoanbeanBindingSource1
            // 
            taiKhoanbeanBindingSource1.DataSource = typeof(bean.TaiKhoanbean);
            // 
            // FormHienThiDSTK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1066, 463);
            Controls.Add(dgvbangtk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormHienThiDSTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHienThiDSTK";
            Load += FormHienThiDSTK_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbangtk).EndInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanbeanBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanbeanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)taiKhoanbeanBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtmanv;
        private TextBox txtmk;
        private TextBox txttendn;
        private TextBox txtmatk;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvbangtk;
        private BindingSource taiKhoanbeanBindingSource;
        private DataGridViewTextBoxColumn maTaiKhoanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quyenDataGridViewTextBoxColumn;
        private BindingSource taiKhoanbeanBindingSource2;
        private BindingSource taiKhoanbeanBindingSource1;
        private Button btntrove;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtquyen;
        private Label label5;
    }
}