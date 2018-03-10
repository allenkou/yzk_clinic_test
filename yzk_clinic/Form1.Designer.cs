namespace yzk_clinic
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_主页 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_购药计算 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_收费记录 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_退出 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel_主 = new System.Windows.Forms.Panel();
            this.toolStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 739);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip_Main.TabIndex = 0;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.AutoSize = false;
            this.toolStrip_Main.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_主页,
            this.toolStripSeparator1,
            this.toolStripButton_购药计算,
            this.toolStripSeparator2,
            this.toolStripButton_收费记录,
            this.toolStripButton_退出,
            this.toolStripSeparator4,
            this.toolStripSeparator3});
            this.toolStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Size = new System.Drawing.Size(1184, 50);
            this.toolStrip_Main.TabIndex = 1;
            this.toolStrip_Main.Text = "toolStrip1";
            // 
            // toolStripButton_主页
            // 
            this.toolStripButton_主页.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_主页.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_主页.Image")));
            this.toolStripButton_主页.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_主页.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_主页.Name = "toolStripButton_主页";
            this.toolStripButton_主页.Size = new System.Drawing.Size(110, 47);
            this.toolStripButton_主页.Text = "主页";
            this.toolStripButton_主页.Click += new System.EventHandler(this.toolStripButton_主页_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton_购药计算
            // 
            this.toolStripButton_购药计算.AutoSize = false;
            this.toolStripButton_购药计算.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_购药计算.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_购药计算.Image")));
            this.toolStripButton_购药计算.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_购药计算.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_购药计算.Name = "toolStripButton_购药计算";
            this.toolStripButton_购药计算.Size = new System.Drawing.Size(180, 33);
            this.toolStripButton_购药计算.Text = "购药计算";
            this.toolStripButton_购药计算.Click += new System.EventHandler(this.toolStripButton_购药计算_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton_收费记录
            // 
            this.toolStripButton_收费记录.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_收费记录.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_收费记录.Image")));
            this.toolStripButton_收费记录.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_收费记录.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_收费记录.Name = "toolStripButton_收费记录";
            this.toolStripButton_收费记录.Size = new System.Drawing.Size(170, 47);
            this.toolStripButton_收费记录.Text = "收费记录";
            // 
            // toolStripButton_退出
            // 
            this.toolStripButton_退出.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_退出.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton_退出.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_退出.Image")));
            this.toolStripButton_退出.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_退出.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_退出.Name = "toolStripButton_退出";
            this.toolStripButton_退出.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton_退出.Size = new System.Drawing.Size(110, 47);
            this.toolStripButton_退出.Text = "退出";
            this.toolStripButton_退出.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton_退出.Click += new System.EventHandler(this.toolStripButton_退出_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // panel_主
            // 
            this.panel_主.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_主.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_主.Location = new System.Drawing.Point(0, 50);
            this.panel_主.Name = "panel_主";
            this.panel_主.Size = new System.Drawing.Size(1184, 689);
            this.panel_主.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel_主);
            this.Controls.Add(this.toolStrip_Main);
            this.Controls.Add(this.statusStrip_Main);
            this.Name = "MainForm";
            this.Text = "廊坊华海门诊部";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip_Main.ResumeLayout(false);
            this.toolStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripButton toolStripButton_购药计算;
        private System.Windows.Forms.ToolStripButton toolStripButton_收费记录;
        private System.Windows.Forms.Panel panel_主;
        private System.Windows.Forms.ToolStripButton toolStripButton_主页;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_退出;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

