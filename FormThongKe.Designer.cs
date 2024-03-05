namespace QuanLyBanSach
{
    partial class FormThongKe
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
            dgvthongke = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            TongHoaDon = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvthongke).BeginInit();
            SuspendLayout();
            // 
            // dgvthongke
            // 
            dgvthongke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvthongke.Columns.AddRange(new DataGridViewColumn[] { STT, Thang, TongHoaDon });
            dgvthongke.Location = new Point(12, 162);
            dgvthongke.Name = "dgvthongke";
            dgvthongke.RowHeadersWidth = 62;
            dgvthongke.RowTemplate.Height = 33;
            dgvthongke.Size = new Size(1025, 326);
            dgvthongke.TabIndex = 0;
            // 
            // STT
            // 
            STT.DataPropertyName = "STT";
            STT.HeaderText = "STT";
            STT.MinimumWidth = 8;
            STT.Name = "STT";
            STT.Width = 150;
            // 
            // Thang
            // 
            Thang.HeaderText = "Tháng";
            Thang.MinimumWidth = 8;
            Thang.Name = "Thang";
            Thang.Width = 150;
            // 
            // TongHoaDon
            // 
            TongHoaDon.HeaderText = "Tổng Hóa Đơn";
            TongHoaDon.MinimumWidth = 8;
            TongHoaDon.Name = "TongHoaDon";
            TongHoaDon.Width = 150;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 500);
            Controls.Add(dgvthongke);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvthongke).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvthongke;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn TongHoaDon;
    }
}