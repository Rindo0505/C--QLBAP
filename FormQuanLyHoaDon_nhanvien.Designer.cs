namespace QuanLyBanSach
{
    partial class FormQuanLyHoaDon_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyHoaDon_nhanvien));
            label1 = new Label();
            dgvbang = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            ngayLapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manvDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewImageColumn();
            hoaDonbeanBindingSource = new BindingSource(components);
            btntrove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvbang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonbeanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(401, 45);
            label1.Name = "label1";
            label1.Size = new Size(353, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Hóa Đơn";
            // 
            // dgvbang
            // 
            dgvbang.AutoGenerateColumns = false;
            dgvbang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbang.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, ngayLapDataGridViewTextBoxColumn, manvDataGridViewTextBoxColumn, ChiTiet });
            dgvbang.DataSource = hoaDonbeanBindingSource;
            dgvbang.Location = new Point(1, 165);
            dgvbang.Name = "dgvbang";
            dgvbang.RowHeadersWidth = 62;
            dgvbang.RowTemplate.Height = 33;
            dgvbang.Size = new Size(1202, 438);
            dgvbang.TabIndex = 1;
            dgvbang.CellClick += dgvbang_CellClick;
            // 
            // MaHoaDon
            // 
            MaHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 8;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.Resizable = DataGridViewTriState.True;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            ngayLapDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            ngayLapDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            // 
            // manvDataGridViewTextBoxColumn
            // 
            manvDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            manvDataGridViewTextBoxColumn.DataPropertyName = "Manv";
            manvDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            manvDataGridViewTextBoxColumn.MinimumWidth = 8;
            manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            ChiTiet.HeaderText = "Chi Tiết";
            ChiTiet.Image = (Image)resources.GetObject("ChiTiet.Image");
            ChiTiet.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ChiTiet.MinimumWidth = 8;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.Resizable = DataGridViewTriState.True;
            ChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            ChiTiet.Width = 150;
            // 
            // hoaDonbeanBindingSource
            // 
            hoaDonbeanBindingSource.DataSource = typeof(bean.HoaDonbean);
            // 
            // btntrove
            // 
            btntrove.Location = new Point(1078, 109);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(112, 34);
            btntrove.TabIndex = 2;
            btntrove.Text = "Trở về";
            btntrove.UseVisualStyleBackColor = true;
            btntrove.Click += btntrove_Click;
            // 
            // FormQuanLyHoaDon_nhanvien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1215, 615);
            Controls.Add(btntrove);
            Controls.Add(dgvbang);
            Controls.Add(label1);
            Name = "FormQuanLyHoaDon_nhanvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanLyHoaDon_nhanvien";
            Load += FormQuanLyHoaDon_nhanvien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbang).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonbeanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvbang;
        private BindingSource hoaDonbeanBindingSource;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private DataGridViewImageColumn ChiTiet;
        private Button btntrove;
    }
}