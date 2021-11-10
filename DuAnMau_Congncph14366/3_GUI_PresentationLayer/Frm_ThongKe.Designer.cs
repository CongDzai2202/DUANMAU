
namespace _3_GUI_PresentationLayer
{
    partial class Frm_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnPhẩmNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmNhậpKhoToolStripMenuItem,
            this.sảnPhẩmTồnKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(18, 23);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(384, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sảnPhẩmNhậpKhoToolStripMenuItem
            // 
            this.sảnPhẩmNhậpKhoToolStripMenuItem.Name = "sảnPhẩmNhậpKhoToolStripMenuItem";
            this.sảnPhẩmNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.sảnPhẩmNhậpKhoToolStripMenuItem.Text = "Sản Phẩm Nhập Kho";
            this.sảnPhẩmNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmNhậpKhoToolStripMenuItem_Click);
            // 
            // sảnPhẩmTồnKhoToolStripMenuItem
            // 
            this.sảnPhẩmTồnKhoToolStripMenuItem.Name = "sảnPhẩmTồnKhoToolStripMenuItem";
            this.sảnPhẩmTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.sảnPhẩmTồnKhoToolStripMenuItem.Text = "Sản Phẩm Tồn Kho";
            this.sảnPhẩmTồnKhoToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmTồnKhoToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(819, 246);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Dong.BackgroundImage")));
            this.btn_Dong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Dong.Location = new System.Drawing.Point(699, 319);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(150, 57);
            this.btn_Dong.TabIndex = 2;
            this.btn_Dong.Text = "       Quay Lại";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 388);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_ThongKe";
            this.Text = "Frm_ThongKe";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmNhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmTồnKhoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Dong;
    }
}