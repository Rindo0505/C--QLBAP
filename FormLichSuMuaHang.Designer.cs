namespace QuanLyBanSach
{
    partial class FormLichSuMuaHang
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
            label1 = new Label();
            dgvbang = new DataGridView();
            btntrove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvbang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(362, 22);
            label1.Name = "label1";
            label1.Size = new Size(389, 60);
            label1.TabIndex = 0;
            label1.Text = "Lịch Sử Bán Hàng";
            // 
            // dgvbang
            // 
            dgvbang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbang.Location = new Point(3, 109);
            dgvbang.Name = "dgvbang";
            dgvbang.RowHeadersWidth = 62;
            dgvbang.RowTemplate.Height = 33;
            dgvbang.Size = new Size(1137, 342);
            dgvbang.TabIndex = 1;
            dgvbang.CellContentClick += dgvbang_CellContentClick;
            // 
            // btntrove
            // 
            btntrove.BackColor = Color.FromArgb(0, 192, 192);
            btntrove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btntrove.Location = new Point(965, 59);
            btntrove.Name = "btntrove";
            btntrove.Size = new Size(146, 44);
            btntrove.TabIndex = 2;
            btntrove.Text = "Trở Về";
            btntrove.UseVisualStyleBackColor = false;
            btntrove.Click += btntrove_Click;
            // 
            // FormLichSuMuaHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1137, 452);
            Controls.Add(btntrove);
            Controls.Add(dgvbang);
            Controls.Add(label1);
            Name = "FormLichSuMuaHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLichSuMuaHang";
            ((System.ComponentModel.ISupportInitialize)dgvbang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvbang;
        private Button btntrove;
    }
}