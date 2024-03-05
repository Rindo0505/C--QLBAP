namespace QuanLyBanSach
{
    partial class FormCTHD_Admin
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
            dgvcthd = new DataGridView();
            maHoaDonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            donGiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chiTietHoaDonbeanBindingSource = new BindingSource(components);
            label1 = new Label();
            btntrove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvcthd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonbeanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvcthd
            // 
            dgvcthd.AutoGenerateColumns = false;
            dgvcthd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcthd.Columns.AddRange(new DataGridViewColumn[] { maHoaDonDataGridViewTextBoxColumn, maSanPhamDataGridViewTextBoxColumn, tenSanPhamDataGridViewTextBoxColumn, soLuongDataGridViewTextBoxColumn, donGiaDataGridViewTextBoxColumn });
            dgvcthd.DataSource = chiTietHoaDonbeanBindingSource;
            dgvcthd.Location = new Point(3, 172);
            dgvcthd.Name = "dgvcthd";
            dgvcthd.RowHeadersWidth = 62;
            dgvcthd.RowTemplate.Height = 33;
            dgvcthd.Size = new Size(1311, 395);
            dgvcthd.TabIndex = 4;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            maHoaDonDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            maHoaDonDataGridViewTextBoxColumn.HeaderText = "Mã Hóa Đơn";
            maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
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
            // soLuongDataGridViewTextBoxColumn
            // 
            soLuongDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            donGiaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá ";
            donGiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // chiTietHoaDonbeanBindingSource
            // 
            chiTietHoaDonbeanBindingSource.DataSource = typeof(bean.ChiTietHoaDonbean);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(451, 20);
            label1.Name = "label1";
            label1.Size = new Size(344, 54);
            label1.TabIndex = 3;
            label1.Text = "Chi Tiết Hóa Đơn";
            // 
            // btntrove
            // 
            btntrove.BackColor = Color.FromArgb(0, 192, 192);
            btntrove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btntrove.Location = new Point(1161, 95);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(112, 34);
            btntrove.TabIndex = 5;
            btntrove.Text = "Trở về";
            btntrove.UseVisualStyleBackColor = false;
            btntrove.Click += btntrove_Click;
            // 
            // FormCTHD_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1317, 579);
            Controls.Add(dgvcthd);
            Controls.Add(label1);
            Controls.Add(btntrove);
            Name = "FormCTHD_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCTHD_Admin";
            ((System.ComponentModel.ISupportInitialize)dgvcthd).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietHoaDonbeanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvcthd;
        private DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private BindingSource chiTietHoaDonbeanBindingSource;
        private Label label1;
        private Button btntrove;
    }
}