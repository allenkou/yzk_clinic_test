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
    public partial class UserControl_单个药品输入 : UserControl
    {
        public UserControl_单个药品输入()
        {
            InitializeComponent();

            this.comboBox_药品名称.DataSource = yzk_购药计算Manager.getInstance().m_ListOf药品名称;
            //this.comboBox_药品名称.Text = String.Empty;
            this.comboBox_药品名称.SelectedIndex = -1;
        }

        private void comboBox_药品名称_Validating(object sender, CancelEventArgs e)
        {
            if (!yzk_购药计算Manager.getInstance().m_ListOf药品名称.Contains(this.comboBox_药品名称.Text))
            {
                this.comboBox_药品名称.Text = String.Empty;
                this.label_单价.Text = "0.00";
                this.textBox_数量.Text = String.Empty;
                this.label_金额.Text = "￥0.00";
                return;
            }

            this.label_单价.Text = yzk_购药计算Manager.getInstance().Get药品单价(this.comboBox_药品名称.Text);
        }

        private void textBox_数量_Validating(object sender, CancelEventArgs e)
        {
            if (this.comboBox_药品名称.Text.Equals(String.Empty))
            {
                this.textBox_数量.Text = String.Empty;
            }
            return;
            int tmp数量 = 0;
            if (Int32.TryParse(this.textBox_数量.Text, out tmp数量))
            {
                MessageBox.Show("数量不能为0", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_数量.Text = String.Empty;
                return;
            }
        }

        private void textBox_数量_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            else
            {
                int tmp数量 = 0;
                Int32.TryParse(this.textBox_数量.Text, out tmp数量);
                if (this.comboBox_药品名称.Text.Equals(String.Empty))
                {
                    MessageBox.Show("请先输入药品名称", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    return;
                    this.textBox_数量.Text = String.Empty;
                }
            }

            


        }

        internal string GetStr药品名称()
        {
            return this.comboBox_药品名称.Text;
        }

        internal string GetStr药品数量g()
        {
            return this.textBox_数量.Text;
        }

        private void textBox_数量_KeyUp(object sender, KeyEventArgs e)
        {
            Double tmpDouble单价 = yzk_购药计算Manager.getInstance().GetDouble药品单价(this.comboBox_药品名称.Text);
            int tmpInt数量 = 0;
            Int32.TryParse(this.textBox_数量.Text, out tmpInt数量);
            Double tmpDouble金额 = tmpDouble单价 * tmpInt数量;
            this.label_金额.Text = "￥" + tmpDouble金额;
        }

        private void comboBox_药品名称_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!yzk_购药计算Manager.getInstance().m_ListOf药品名称.Contains(this.comboBox_药品名称.Text))
            {
                this.comboBox_药品名称.Text = String.Empty;
                this.label_单价.Text = "0.00";
                this.textBox_数量.Text = String.Empty;
                this.label_金额.Text = "￥0.00";
                return;
            }

            this.label_单价.Text = yzk_购药计算Manager.getInstance().Get药品单价(this.comboBox_药品名称.Text);

            Double tmpDouble单价 = yzk_购药计算Manager.getInstance().GetDouble药品单价(this.comboBox_药品名称.Text);
            int tmpInt数量 = 0;
            Int32.TryParse(this.textBox_数量.Text, out tmpInt数量);
            Double tmpDouble金额 = tmpDouble单价 * tmpInt数量;
            this.label_金额.Text = "￥" + tmpDouble金额;
        }

        private void button_删除_Click(object sender, EventArgs e)
        {
            yzk_购药计算Manager.getInstance().Del一行(this);
        }
    }
}
