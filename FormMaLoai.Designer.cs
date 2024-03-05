namespace QuanLyBanSach
{
    partial class FormMaLoai
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
            txttensp = new TextBox();
            txtmasp = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dgvbang = new DataGridView();
            maLoaiSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenLoaiSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maLoaibeanBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maLoaibeanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txttensp);
            groupBox1.Controls.Add(txtmasp);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1170, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txttensp
            // 
            txttensp.Location = new Point(811, 84);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(319, 31);
            txttensp.TabIndex = 1;
            // 
            // txtmasp
            // 
            txtmasp.Location = new Point(177, 84);
            txtmasp.Name = "txtmasp";
            txtmasp.Size = new Size(319, 31);
            txtmasp.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(427, 9);
            label3.Name = "label3";
            label3.Size = new Size(329, 48);
            label3.TabIndex = 0;
            label3.Text = "Mã Loại Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(657, 87);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(22, 87);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Sản Phẩm";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 405);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1170, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 192);
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(750, 30);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 0;
            button4.Text = "Trở về";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(564, 30);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 0;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(374, 30);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 0;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(196, 30);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvbang
            // 
            dgvbang.AutoGenerateColumns = false;
            dgvbang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbang.Columns.AddRange(new DataGridViewColumn[] { maLoaiSanPhamDataGridViewTextBoxColumn, tenLoaiSanPhamDataGridViewTextBoxColumn });
            dgvbang.DataSource = maLoaibeanBindingSource;
            dgvbang.Dock = DockStyle.Fill;
            dgvbang.Location = new Point(0, 152);
            dgvbang.Name = "dgvbang";
            dgvbang.RowHeadersWidth = 62;
            dgvbang.RowTemplate.Height = 33;
            dgvbang.Size = new Size(1170, 253);
            dgvbang.TabIndex = 2;
            dgvbang.CellClick += dgvbang_CellClick;
            // 
            // maLoaiSanPhamDataGridViewTextBoxColumn
            // 
            maLoaiSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maLoaiSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSanPham";
            maLoaiSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã Loại Sản Phẩm";
            maLoaiSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            maLoaiSanPhamDataGridViewTextBoxColumn.Name = "maLoaiSanPhamDataGridViewTextBoxColumn";
            // 
            // tenLoaiSanPhamDataGridViewTextBoxColumn
            // 
            tenLoaiSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenLoaiSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiSanPham";
            tenLoaiSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên Loại Sản Phẩm";
            tenLoaiSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenLoaiSanPhamDataGridViewTextBoxColumn.Name = "tenLoaiSanPhamDataGridViewTextBoxColumn";
            // 
            // maLoaibeanBindingSource
            // 
            maLoaibeanBindingSource.DataSource = typeof(bean.MaLoaibean);
            // 
            // FormMaLoai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 485);
            Controls.Add(dgvbang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMaLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMaLoai";
            Load += FormMaLoai_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbang).EndInit();
            ((System.ComponentModel.ISupportInitialize)maLoaibeanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvbang;
        private TextBox txttensp;
        private TextBox txtmasp;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn maLoaiSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiSanPhamDataGridViewTextBoxColumn;
        private BindingSource maLoaibeanBindingSource;
    }
}