namespace QuanLyBanSach
{
    partial class FormDSNV
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
            dtpngaysinh = new DateTimePicker();
            txtgioitinh = new TextBox();
            txttnv = new TextBox();
            txtmanv = new TextBox();
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
            dgvbang = new DataGridView();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaySinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gioiTinhDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            nhanVienbeanBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienbeanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(dtpngaysinh);
            groupBox1.Controls.Add(txtgioitinh);
            groupBox1.Controls.Add(txttnv);
            groupBox1.Controls.Add(txtmanv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1273, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Location = new Point(865, 66);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(320, 34);
            dtpngaysinh.TabIndex = 2;
            // 
            // txtgioitinh
            // 
            txtgioitinh.Location = new Point(865, 131);
            txtgioitinh.Name = "txtgioitinh";
            txtgioitinh.Size = new Size(320, 34);
            txtgioitinh.TabIndex = 1;
            // 
            // txttnv
            // 
            txttnv.Location = new Point(205, 125);
            txttnv.Name = "txttnv";
            txttnv.Size = new Size(247, 34);
            txttnv.TabIndex = 1;
            // 
            // txtmanv
            // 
            txtmanv.Location = new Point(205, 66);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(247, 34);
            txtmanv.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(742, 131);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 0;
            label5.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(742, 66);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 0;
            label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 134);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 0;
            label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 71);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(408, 9);
            label1.Name = "label1";
            label1.Size = new Size(443, 48);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btntrove);
            groupBox2.Controls.Add(btnxoa);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(btnthem);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 410);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1273, 68);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btntrove
            // 
            btntrove.BackColor = Color.FromArgb(0, 192, 192);
            btntrove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btntrove.Location = new Point(789, 22);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(112, 34);
            btntrove.TabIndex = 0;
            btntrove.Text = "Trở Về";
            btntrove.UseVisualStyleBackColor = false;
            btntrove.Click += btntrove_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.Yellow;
            btnxoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoa.Location = new Point(600, 22);
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
            btnsua.Location = new Point(408, 22);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(112, 34);
            btnsua.TabIndex = 0;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Red;
            btnthem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.Location = new Point(205, 22);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(112, 34);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // dgvbang
            // 
            dgvbang.AutoGenerateColumns = false;
            dgvbang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbang.Columns.AddRange(new DataGridViewColumn[] { maNhanVienDataGridViewTextBoxColumn, tenNhanVienDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, gioiTinhDataGridViewCheckBoxColumn });
            dgvbang.DataSource = nhanVienbeanBindingSource;
            dgvbang.Dock = DockStyle.Fill;
            dgvbang.Location = new Point(0, 182);
            dgvbang.Name = "dgvbang";
            dgvbang.RowHeadersWidth = 62;
            dgvbang.RowTemplate.Height = 33;
            dgvbang.Size = new Size(1273, 228);
            dgvbang.TabIndex = 2;
            dgvbang.CellClick += dgvbang_CellClick;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            maNhanVienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            tenNhanVienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            gioiTinhDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewCheckBoxColumn.HeaderText = "Giới Tính";
            gioiTinhDataGridViewCheckBoxColumn.MinimumWidth = 8;
            gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            // 
            // nhanVienbeanBindingSource
            // 
            nhanVienbeanBindingSource.DataSource = typeof(bean.NhanVienbean);
            // 
            // FormDSNV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 478);
            Controls.Add(dgvbang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormDSNV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDSNV";
            Load += FormDSNV_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienbeanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtpngaysinh;
        private TextBox txtgioitinh;
        private TextBox txttnv;
        private TextBox txtmanv;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvbang;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private BindingSource nhanVienbeanBindingSource;
        private Button btntrove;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
    }
}