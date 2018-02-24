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
            this.toolStripButton_购药计算 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_收费记录 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 655);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(1563, 22);
            this.statusStrip_Main.TabIndex = 0;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_购药计算,
            this.toolStripButton_收费记录});
            this.toolStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Size = new System.Drawing.Size(1563, 25);
            this.toolStrip_Main.TabIndex = 1;
            this.toolStrip_Main.Text = "toolStrip1";
            // 
            // toolStripButton_购药计算
            // 
            this.toolStripButton_购药计算.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_购药计算.Image")));
            this.toolStripButton_购药计算.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_购药计算.Name = "toolStripButton_购药计算";
            this.toolStripButton_购药计算.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton_购药计算.Text = "购药计算";
            // 
            // toolStripButton_收费记录
            // 
            this.toolStripButton_收费记录.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_收费记录.Image")));
            this.toolStripButton_收费记录.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_收费记录.Name = "toolStripButton_收费记录";
            this.toolStripButton_收费记录.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton_收费记录.Text = "收费记录";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 677);
            this.Controls.Add(this.toolStrip_Main);
            this.Controls.Add(this.statusStrip_Main);
            this.Name = "MainForm";
            this.Text = "廊坊华海门诊部";
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
    }
}

