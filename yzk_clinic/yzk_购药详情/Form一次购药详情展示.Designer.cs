namespace yzk_clinic.yzk_购药详情
{
    partial class Form一次购药详情展示
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
            this.label_购药人信息 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_药品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_总额 = new System.Windows.Forms.Label();
            this.label_金额实际值 = new System.Windows.Forms.Label();
            this.button_确定 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.label_收费时间 = new System.Windows.Forms.Label();
            this.label_实际时间 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_购药人信息
            // 
            this.label_购药人信息.AutoSize = true;
            this.label_购药人信息.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_购药人信息.Location = new System.Drawing.Point(30, 27);
            this.label_购药人信息.Name = "label_购药人信息";
            this.label_购药人信息.Size = new System.Drawing.Size(249, 24);
            this.label_购药人信息.TabIndex = 0;
            this.label_购药人信息.Text = "姓名 性别 年龄 电话";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_药品名称,
            this.Column_单价,
            this.Column_数量,
            this.Column_金额});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(875, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_药品名称
            // 
            this.Column_药品名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_药品名称.FillWeight = 30F;
            this.Column_药品名称.HeaderText = "药品名称";
            this.Column_药品名称.Name = "Column_药品名称";
            this.Column_药品名称.ReadOnly = true;
            // 
            // Column_单价
            // 
            this.Column_单价.HeaderText = "单价/g";
            this.Column_单价.Name = "Column_单价";
            this.Column_单价.ReadOnly = true;
            this.Column_单价.Width = 150;
            // 
            // Column_数量
            // 
            this.Column_数量.HeaderText = "数量（g）";
            this.Column_数量.Name = "Column_数量";
            this.Column_数量.ReadOnly = true;
            this.Column_数量.Width = 150;
            // 
            // Column_金额
            // 
            this.Column_金额.HeaderText = "金额";
            this.Column_金额.Name = "Column_金额";
            this.Column_金额.ReadOnly = true;
            this.Column_金额.Width = 150;
            // 
            // label_总额
            // 
            this.label_总额.AutoSize = true;
            this.label_总额.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_总额.Location = new System.Drawing.Point(606, 27);
            this.label_总额.Name = "label_总额";
            this.label_总额.Size = new System.Drawing.Size(85, 24);
            this.label_总额.TabIndex = 0;
            this.label_总额.Text = "总额：";
            // 
            // label_金额实际值
            // 
            this.label_金额实际值.AutoSize = true;
            this.label_金额实际值.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_金额实际值.Location = new System.Drawing.Point(697, 27);
            this.label_金额实际值.Name = "label_金额实际值";
            this.label_金额实际值.Size = new System.Drawing.Size(60, 24);
            this.label_金额实际值.TabIndex = 0;
            this.label_金额实际值.Text = "金额";
            // 
            // button_确定
            // 
            this.button_确定.AutoSize = true;
            this.button_确定.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_确定.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_确定.Location = new System.Drawing.Point(616, 377);
            this.button_确定.Name = "button_确定";
            this.button_确定.Size = new System.Drawing.Size(75, 34);
            this.button_确定.TabIndex = 2;
            this.button_确定.Text = "确定";
            this.button_确定.UseVisualStyleBackColor = true;
            // 
            // button_取消
            // 
            this.button_取消.AutoSize = true;
            this.button_取消.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_取消.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_取消.Location = new System.Drawing.Point(765, 377);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(75, 34);
            this.button_取消.TabIndex = 2;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // label_收费时间
            // 
            this.label_收费时间.AutoSize = true;
            this.label_收费时间.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_收费时间.Location = new System.Drawing.Point(30, 380);
            this.label_收费时间.Name = "label_收费时间";
            this.label_收费时间.Size = new System.Drawing.Size(135, 24);
            this.label_收费时间.TabIndex = 0;
            this.label_收费时间.Text = "收费时间：";
            // 
            // label_实际时间
            // 
            this.label_实际时间.AutoSize = true;
            this.label_实际时间.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_实际时间.Location = new System.Drawing.Point(176, 380);
            this.label_实际时间.Name = "label_实际时间";
            this.label_实际时间.Size = new System.Drawing.Size(257, 24);
            this.label_实际时间.TabIndex = 0;
            this.label_实际时间.Text = "YYYY-MM-DD HH:mm:ss";
            // 
            // Form一次购药详情展示
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 434);
            this.ControlBox = false;
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_确定);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_实际时间);
            this.Controls.Add(this.label_金额实际值);
            this.Controls.Add(this.label_收费时间);
            this.Controls.Add(this.label_总额);
            this.Controls.Add(this.label_购药人信息);
            this.Name = "Form一次购药详情展示";
            this.Text = "购药详情";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_购药人信息;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_总额;
        private System.Windows.Forms.Label label_金额实际值;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_药品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_金额;
        private System.Windows.Forms.Button button_确定;
        private System.Windows.Forms.Button button_取消;
        private System.Windows.Forms.Label label_收费时间;
        private System.Windows.Forms.Label label_实际时间;
    }
}