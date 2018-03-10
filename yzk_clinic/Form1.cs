using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzk_clinic.yzk_购药计算;

namespace yzk_clinic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton_购药计算_Click(object sender, EventArgs e)
        {
            yzk_购药计算Manager.getInstance().Display购药计算界面();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            yzk_购药计算Manager.getInstance().Init界面初始化(this.panel_主);

        }

        private void toolStripButton_主页_Click(object sender, EventArgs e)
        {
            this.to主页();
        }

        private void to主页()
        {
            yzk_购药计算Manager.getInstance().Hide购药计算界面();
        }

        private void toolStripButton_退出_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
