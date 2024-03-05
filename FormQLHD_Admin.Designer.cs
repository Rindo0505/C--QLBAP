namespace QuanLyBanSach
{
    partial class FormQLHD_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHD_Admin));
            dgvbang = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            ngayLapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manvDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewImageColumn();
            hoaDonbeanBindingSource = new BindingSource(components);
            label1 = new Label();
            btntrove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvbang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonbeanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvbang
            // 
            dgvbang.AutoGenerateColumns = false;
            dgvbang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbang.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, ngayLapDataGridViewTextBoxColumn, manvDataGridViewTextBoxColumn, ChiTiet });
            dgvbang.DataSource = hoaDonbeanBindingSource;
            dgvbang.Location = new Point(7, 156);
            dgvbang.Name = "dgvbang";
            dgvbang.RowHeadersWidth = 62;
            dgvbang.RowTemplate.Height = 33;
            dgvbang.Size = new Size(1077, 361);
            dgvbang.TabIndex = 4;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(333, 21);
            label1.Name = "label1";
            label1.Size = new Size(353, 54);
            label1.TabIndex = 3;
            label1.Text = "Quản Lý Hóa Đơn";
            // 
            // btntrove
            // 
            btntrove.BackColor = Color.FromArgb(0, 192, 192);
            btntrove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btntrove.Location = new Point(917, 95);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(138, 45);
            btntrove.TabIndex = 5;
            btntrove.Text = "Trở về";
            btntrove.UseVisualStyleBackColor = false;
            btntrove.Click += btntrove_Click;
            // 
            // FormQLHD_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1090, 509);
            Controls.Add(dgvbang);
            Controls.Add(label1);
            Controls.Add(btntrove);
            Name = "FormQLHD_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQLHD_Admin";
            ((System.ComponentModel.ISupportInitialize)dgvbang).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonbeanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvbang;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private DataGridViewImageColumn ChiTiet;
        private BindingSource hoaDonbeanBindingSource;
        private Label label1;
        private Button btntrove;
    }
}