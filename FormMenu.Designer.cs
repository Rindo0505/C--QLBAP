namespace QuanLyBanSach
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            panel1 = new Panel();
            toolStrip2 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tstml = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            btnQLHD = new ToolStripMenuItem();
            toolStripButton4 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            btnThongKe = new ToolStripMenuItem();
            panel1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(369, 27);
            label1.Name = "label1";
            label1.Size = new Size(207, 74);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Location = new Point(0, 485);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(987, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-10, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 343);
            panel1.TabIndex = 3;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripButton4, toolStripButton1 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(391, 34);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, tstml, toolStripMenuItem2, btnQLHD, btnThongKe });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(75, 29);
            toolStripDropDownButton1.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(270, 34);
            toolStripMenuItem1.Text = "Quản lý danh mục";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // tstml
            // 
            tstml.Name = "tstml";
            tstml.Size = new Size(270, 34);
            tstml.Text = "Quản Lý Mã Loại";
            tstml.Click += tstml_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(270, 34);
            toolStripMenuItem2.Text = "Quản Lý Nhân Viên";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // btnQLHD
            // 
            btnQLHD.Name = "btnQLHD";
            btnQLHD.Size = new Size(270, 34);
            btnQLHD.Text = "Quản Lý Hóa Đơn";
            btnQLHD.Click += btnQLHD_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(97, 29);
            toolStripButton4.Text = "Đăng xuất";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(155, 29);
            toolStripButton1.Text = "Quản lý tài khoản";
            toolStripButton1.Click += toolStripButton1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(967, 371);
            dataGridView1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(270, 34);
            btnThongKe.Text = "Thống Kê";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(987, 510);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private Panel panel1;
        private ToolStrip toolStrip2;
        private DataGridView dataGridView1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem tstml;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem btnQLHD;
        private ToolStripMenuItem btnThongKe;
    }
}