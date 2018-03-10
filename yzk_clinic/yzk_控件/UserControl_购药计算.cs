using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
