namespace QuanLyBanSach
{
    partial class FormQuanLyBanHang
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
            btnbh = new Button();
            btnqlhd = new Button();
            btnlsmh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 34);
            label1.Name = "label1";
            label1.Size = new Size(409, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Bán Hàng";
            // 
            // btnbh
            // 
            btnbh.BackColor = Color.FromArgb(255, 128, 128);
            btnbh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnbh.Location = new Point(58, 159);
            btnbh.Name = "btnbh";
            btnbh.Size = new Size(178, 75);
            btnbh.TabIndex = 1;
            btnbh.Text = "Bán Hàng";
            btnbh.UseVisualStyleBackColor = false;
            btnbh.Click += btnbh_Click;
            // 
            // btnqlhd
            // 
            btnqlhd.BackColor = Color.FromArgb(255, 255, 128);
            btnqlhd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnqlhd.Location = new Point(319, 159);
            btnqlhd.Name = "btnqlhd";
            btnqlhd.Size = new Size(178, 75);
            btnqlhd.TabIndex = 1;
            btnqlhd.Text = "Quản Lý Hóa Đơn";
            btnqlhd.UseVisualStyleBackColor = false;
            btnqlhd.Click += btnqlhd_Click;
            // 
            // btnlsmh
            // 
            btnlsmh.BackColor = Color.FromArgb(0, 192, 192);
            btnlsmh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnlsmh.Location = new Point(569, 159);
            btnlsmh.Name = "btnlsmh";
            btnlsmh.Size = new Size(178, 75);
            btnlsmh.TabIndex = 1;
            btnlsmh.Text = "Lịch Sử Mua Hàng";
            btnlsmh.UseVisualStyleBackColor = false;
            btnlsmh.Click += btnlsmh_Click;
            // 
            // FormQuanLyBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(867, 368);
            Controls.Add(btnlsmh);
            Controls.Add(btnqlhd);
            Controls.Add(btnbh);
            Controls.Add(label1);
            Name = "FormQuanLyBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanLyBanHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnbh;
        private Button btnqlhd;
        private Button btnlsmh;
    }
}