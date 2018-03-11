using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzk_clinic.yzk_购药详情
{
    public partial class Form一次购药详情展示 : Form
    {
        //public Dictionary<string, yzk_一行购药药品记录> m_DicOf一行购药药品记录;
        

        public Form一次购药详情展示()
        {
            InitializeComponent();
        }

        public Form一次购药详情展示(string para姓名, string para性别, string para年龄, string para电话, string paraStr收费时间, double para总额)
        {
            InitializeComponent();

            this.label_购药人信息.Text = para姓名 + " " + para性别 + " " + para年龄 + " " + para电话;
            this.label_金额实际值.Text = "￥" + para总额.ToString();
            this.label_实际时间.Text = paraStr收费时间;
            //this.m_DicOf一行购药药品记录 = paraDicOf一行购药药品记录;
            this.ShowDialog();
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
