﻿namespace yzk_clinic.yzk_控件
{
    partial class UserControl_单个药品输入
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
            this.comboBox_药品名称 = new System.Windows.Forms.ComboBox();
            this.label_单价 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_金额 = new System.Windows.Forms.Label();
            this.button_删除 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_药品名称
            // 
            this.comboBox_药品名称.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_药品名称.FormattingEnabled = true;
            this.comboBox_药品名称.Location = new System.Drawing.Point(14, 15);
            this.comboBox_药品名称.Name = "comboBox_药品名称";
            this.comboBox_药品名称.Size = new System.Drawing.Size(350, 35);
            this.comboBox_药品名称.TabIndex = 0;
            // 
            // label_单价
            // 
            this.label_单价.AutoSize = true;
            this.label_单价.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_单价.Location = new System.Drawing.Point(423, 18);
            this.label_单价.Name = "label_单价";
            this.label_单价.Size = new System.Drawing.Size(68, 27);
            this.label_单价.TabIndex = 1;
            this.label_单价.Text = "0.00";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(544, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 2;
            // 
            // label_金额
            // 
            this.label_金额.AutoSize = true;
            this.label_金额.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_金额.Location = new System.Drawing.Point(719, 18);
            this.label_金额.Name = "label_金额";
            this.label_金额.Size = new System.Drawing.Size(95, 27);
            this.label_金额.TabIndex = 1;
            this.label_金额.Text = "￥0.00";
            // 
            // button_删除
            // 
            this.button_删除.AutoSize = true;
            this.button_删除.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_删除.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_删除.Location = new System.Drawing.Point(884, 13);
            this.button_删除.Name = "button_删除";
            this.button_删除.Size = new System.Drawing.Size(93, 37);
            this.button_删除.TabIndex = 3;
            this.button_删除.Text = "删除";
            this.button_删除.UseVisualStyleBackColor = true;
            // 
            // UserControl_单个药品输入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_删除);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_金额);
            this.Controls.Add(this.label_单价);
            this.Controls.Add(this.comboBox_药品名称);
            this.Name = "UserControl_单个药品输入";
            this.Size = new System.Drawing.Size(1000, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_药品名称;
        private System.Windows.Forms.Label label_单价;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_金额;
        private System.Windows.Forms.Button button_删除;
    }
}
