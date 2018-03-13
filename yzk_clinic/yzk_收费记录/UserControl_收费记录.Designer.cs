namespace yzk_clinic.yzk_收费记录
{
    partial class UserControl_收费记录
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
            this.dateTimePicker_开始 = new System.Windows.Forms.DateTimePicker();
            this.label_时间 = new System.Windows.Forms.Label();
            this.dateTimePicker_结束 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_查询 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_收费时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_购药人姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_详细 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label_合计 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_开始
            // 
            this.dateTimePicker_开始.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker_开始.Location = new System.Drawing.Point(132, 26);
            this.dateTimePicker_开始.Name = "dateTimePicker_开始";
            this.dateTimePicker_开始.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker_开始.TabIndex = 0;
            // 
            // label_时间
            // 
            this.label_时间.AutoSize = true;
            this.label_时间.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_时间.Location = new System.Drawing.Point(30, 33);
            this.label_时间.Name = "label_时间";
            this.label_时间.Size = new System.Drawing.Size(73, 24);
            this.label_时间.TabIndex = 1;
            this.label_时间.Text = "时间:";
            // 
            // dateTimePicker_结束
            // 
            this.dateTimePicker_结束.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker_结束.Location = new System.Drawing.Point(397, 26);
            this.dateTimePicker_结束.Name = "dateTimePicker_结束";
            this.dateTimePicker_结束.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker_结束.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(355, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // button_查询
            // 
            this.button_查询.AutoSize = true;
            this.button_查询.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_查询.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_查询.Location = new System.Drawing.Point(686, 27);
            this.button_查询.Name = "button_查询";
            this.button_查询.Size = new System.Drawing.Size(75, 34);
            this.button_查询.TabIndex = 2;
            this.button_查询.Text = "查询";
            this.button_查询.UseVisualStyleBackColor = true;
            this.button_查询.Click += new System.EventHandler(this.button_查询_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_收费时间,
            this.Column_购药人姓名,
            this.Column_金额,
            this.Column_详细});
            this.dataGridView1.Location = new System.Drawing.Point(34, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 527);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_收费时间
            // 
            this.Column_收费时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_收费时间.FillWeight = 25F;
            this.Column_收费时间.HeaderText = "收费时间";
            this.Column_收费时间.Name = "Column_收费时间";
            this.Column_收费时间.ReadOnly = true;
            // 
            // Column_购药人姓名
            // 
            this.Column_购药人姓名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_购药人姓名.FillWeight = 25F;
            this.Column_购药人姓名.HeaderText = "购药人姓名";
            this.Column_购药人姓名.Name = "Column_购药人姓名";
            this.Column_购药人姓名.ReadOnly = true;
            // 
            // Column_金额
            // 
            this.Column_金额.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_金额.FillWeight = 25F;
            this.Column_金额.HeaderText = "金额";
            this.Column_金额.Name = "Column_金额";
            this.Column_金额.ReadOnly = true;
            // 
            // Column_详细
            // 
            this.Column_详细.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_详细.FillWeight = 25F;
            this.Column_详细.HeaderText = "详细";
            this.Column_详细.Name = "Column_详细";
            this.Column_详细.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "合计:";
            // 
            // label_合计
            // 
            this.label_合计.AutoSize = true;
            this.label_合计.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_合计.Location = new System.Drawing.Point(128, 638);
            this.label_合计.Name = "label_合计";
            this.label_合计.Size = new System.Drawing.Size(23, 24);
            this.label_合计.TabIndex = 1;
            this.label_合计.Text = "0";
            // 
            // UserControl_收费记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_查询);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_合计);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_时间);
            this.Controls.Add(this.dateTimePicker_结束);
            this.Controls.Add(this.dateTimePicker_开始);
            this.Name = "UserControl_收费记录";
            this.Size = new System.Drawing.Size(1180, 680);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_开始;
        private System.Windows.Forms.Label label_时间;
        private System.Windows.Forms.DateTimePicker dateTimePicker_结束;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_查询;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_合计;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_收费时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_购药人姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_金额;
        private System.Windows.Forms.DataGridViewButtonColumn Column_详细;
    }
}
