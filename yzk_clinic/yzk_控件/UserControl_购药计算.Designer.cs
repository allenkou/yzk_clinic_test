namespace yzk_clinic.yzk_控件
{
    partial class UserControl_购药计算
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_个人信息 = new System.Windows.Forms.GroupBox();
            this.groupBox_药品列表 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_个人信息);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_药品列表);
            this.splitContainer1.Size = new System.Drawing.Size(1180, 700);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox_个人信息
            // 
            this.groupBox_个人信息.BackColor = System.Drawing.Color.White;
            this.groupBox_个人信息.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_个人信息.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_个人信息.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_个人信息.Location = new System.Drawing.Point(0, 0);
            this.groupBox_个人信息.Name = "groupBox_个人信息";
            this.groupBox_个人信息.Size = new System.Drawing.Size(1180, 175);
            this.groupBox_个人信息.TabIndex = 0;
            this.groupBox_个人信息.TabStop = false;
            this.groupBox_个人信息.Text = "个人信息";
            // 
            // groupBox_药品列表
            // 
            this.groupBox_药品列表.BackColor = System.Drawing.Color.White;
            this.groupBox_药品列表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_药品列表.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_药品列表.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox_药品列表.Location = new System.Drawing.Point(0, 0);
            this.groupBox_药品列表.Name = "groupBox_药品列表";
            this.groupBox_药品列表.Size = new System.Drawing.Size(1180, 517);
            this.groupBox_药品列表.TabIndex = 0;
            this.groupBox_药品列表.TabStop = false;
            this.groupBox_药品列表.Text = "药品列表";
            // 
            // UserControl_购药计算
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl_购药计算";
            this.Size = new System.Drawing.Size(1180, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_个人信息;
        private System.Windows.Forms.GroupBox groupBox_药品列表;
    }
}
