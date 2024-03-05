namespace QuanLyBanSach
{
    partial class FormTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txttdn = new TextBox();
            txtmk = new TextBox();
            btnDangnhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 19);
            label1.Name = "label1";
            label1.Size = new Size(412, 48);
            label1.TabIndex = 0;
            label1.Text = "Welcome Shop Rin Đô";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(203, 142);
            label2.Name = "label2";
            label2.Size = new Size(200, 38);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(203, 225);
            label3.Name = "label3";
            label3.Size = new Size(135, 38);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // txttdn
            // 
            txttdn.Location = new Point(483, 150);
            txttdn.Name = "txttdn";
            txttdn.Size = new Size(291, 31);
            txttdn.TabIndex = 3;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(483, 225);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(291, 31);
            txtmk.TabIndex = 3;
            txtmk.UseSystemPasswordChar = true;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.Location = new Point(350, 313);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(261, 56);
            btnDangnhap.TabIndex = 4;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // FormTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1007, 456);
            Controls.Add(btnDangnhap);
            Controls.Add(txtmk);
            Controls.Add(txttdn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTaiKhoan";
            Load += FormTaiKhoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttdn;
        private TextBox txtmk;
        private Button btnDangnhap;
    }
}