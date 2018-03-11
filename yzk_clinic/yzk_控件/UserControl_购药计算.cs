using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzk_clinic.yzk_购药计算;

namespace yzk_clinic.yzk_控件
{
    public partial class UserControl_购药计算 : UserControl
    {
        public UserControl_购药计算()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_收费_Click(object sender, EventArgs e)
        {
            String tmp姓名 = this.textBox_姓名.Text;
            if (tmp姓名.Trim().Equals(String.Empty))
            {
                MessageBox.Show("姓名不能为空", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //String tmp姓名 = this.textBox_姓名.Text;
            String tmp性别 = "男";
            if (radioButton_女.Checked)
            {
                tmp性别 = "女";
            }

            String tmp年龄 = this.textBox_年龄.Text;
            String tmp电话 = this.textBox_电话.Text;

            yzk_购药计算Manager.getInstance().Display收费详情(tmp姓名, tmp性别, tmp年龄, tmp电话);

            
        }

        private void button_清空药品_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("清空药品列表", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                yzk_购药计算Manager.getInstance().Del所有行();
            }
        }

        internal void Add单个药品输入控件_自定义(out UserControl_单个药品输入 para单个药品输入控件)
        {
            UserControl_单个药品输入 tmpKK = new UserControl_单个药品输入();
            para单个药品输入控件 = tmpKK;
            tmpKK.Dock = DockStyle.Top;
            //this.panel_药品输入控件.Controls.Add(tmpKK);
            this.flowLayoutPanel_药品列表输入.Controls.Add(tmpKK);

        }

        private void button_增加一行_Click(object sender, EventArgs e)
        {
            yzk_购药计算Manager.getInstance().Add新一行();
        }

        internal void Del单个药品输入控件_自定义(UserControl_单个药品输入 para一行)
        {
            this.flowLayoutPanel_药品列表输入.Controls.Remove(para一行);
        }
    }
}
