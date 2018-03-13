using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzk_clinic.yzk_收费记录;
using yzk_clinic.yzk_购药计算;

namespace yzk_clinic.yzk_购药详情
{
    public partial class Form一次购药详情展示 : Form
    {
        private Dictionary<string, yzk_一行购药药品记录> m_DicOf一行购药药品记录;

        //public Dictionary<string, yzk_一行购药药品记录> m_DicOf一行购药药品记录;


        public Form一次购药详情展示()
        {
            InitializeComponent();
        }

        private String m_Str姓名 = String.Empty;
        private String m_Str性别 = String.Empty;
        private String m_Str年龄 = String.Empty;
        private String m_Str电话 = String.Empty;
        private String m_Str收费时间 = String.Empty;
        private String m_Str总额 = String.Empty;

        public Form一次购药详情展示(Enum_购药详细信息显示来源 paraEnum购药详细信息显示来源, string para姓名, string para性别, string para年龄, string para电话, string paraStr收费时间, double para总额)
        {
            InitializeComponent();

            this.m_Str姓名 = para姓名;
            this.m_Str性别 = para性别;
            this.m_Str年龄 = para年龄;
            this.m_Str电话 = para电话;
            this.m_Str收费时间 = paraStr收费时间;
            this.m_Str总额 = para总额.ToString() ;
            

            this.label_购药人信息.Text = para姓名 + " " + para性别 + " " + para年龄 + " " + para电话;
            this.label_金额实际值.Text = "￥" + para总额.ToString();
            this.label_实际时间.Text = paraStr收费时间;
            //this.m_DicOf一行购药药品记录 = paraDicOf一行购药药品记录;
            this.ShowDialog();
        }

        public Form一次购药详情展示(Enum_购药详细信息显示来源 paraEnum购药详细信息显示来源, string para姓名, string para性别, string para年龄, string para电话, string paraStr收费时间, double para总额, Dictionary<string, yzk_一行购药药品记录> paraDicOf一行购药药品记录)
        {
            InitializeComponent();
            this.m_Str姓名 = para姓名;
            this.m_Str性别 = para性别;
            this.m_Str年龄 = para年龄;
            this.m_Str电话 = para电话;
            this.m_Str收费时间 = paraStr收费时间;
            this.m_Str总额 = para总额.ToString();

            this.m_DicOf一行购药药品记录 = paraDicOf一行购药药品记录;
            foreach (KeyValuePair<String, yzk_一行购药药品记录> tmpKVP in this.m_DicOf一行购药药品记录)
            {
                int tmpIndex = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[tmpIndex].Cells[0].Value = tmpKVP.Value.Get药品名称();
                this.dataGridView1.Rows[tmpIndex].Cells[1].Value = tmpKVP.Value.GetStr单价();
                this.dataGridView1.Rows[tmpIndex].Cells[2].Value = tmpKVP.Value.GetStr数量();
                this.dataGridView1.Rows[tmpIndex].Cells[3].Value = tmpKVP.Value.GetStr金额();
            }
            

            this.label_购药人信息.Text = para姓名 + " " + para性别 + " " + para年龄 + " " + para电话;
            this.label_金额实际值.Text = "￥" + para总额.ToString();
            this.label_实际时间.Text = paraStr收费时间;
            //this.m_DicOf一行购药药品记录 = paraDicOf一行购药药品记录;
            this.ShowDialog();
        }

        /// <summary>
        /// 查询收费记录时用
        /// </summary>
        /// <param name="paraEnum购药详细信息显示来源"></param>
        /// <param name="para姓名"></param>
        /// <param name="para性别"></param>
        /// <param name="para年龄"></param>
        /// <param name="para电话"></param>
        /// <param name="paraStr收费时间"></param>
        /// <param name="para总额"></param>
        /// <param name="paraDicOf一行购药药品记录"></param>
        public Form一次购药详情展示(Enum_购药详细信息显示来源 paraEnum购药详细信息显示来源, string para姓名, string para性别, string para年龄, string para电话, string paraStr收费时间, string paraStr总额, List<yzk_购药记录中的一种药> paraListOf购药记录中的一种药)
        {
            InitializeComponent();
            this.m_Str姓名 = para姓名;
            this.m_Str性别 = para性别;
            this.m_Str年龄 = para年龄;
            this.m_Str电话 = para电话;
            this.m_Str收费时间 = paraStr收费时间;
            this.m_Str总额 = paraStr总额.ToString();

#if true
            

            foreach (yzk_购药记录中的一种药 tmpKK in paraListOf购药记录中的一种药)
            {
                int tmpIndex = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[tmpIndex].Cells[0].Value = tmpKK.Get药品名称();
                this.dataGridView1.Rows[tmpIndex].Cells[1].Value = tmpKK.GetStr单价();
                this.dataGridView1.Rows[tmpIndex].Cells[2].Value = tmpKK.GetStr数量();
                this.dataGridView1.Rows[tmpIndex].Cells[3].Value = tmpKK.GetStr金额();
            }
#endif


            this.label_购药人信息.Text = para姓名 + " " + para性别 + " " + para年龄 + " " + para电话;
            this.label_金额实际值.Text = "￥" + paraStr总额.ToString();
            this.label_实际时间.Text = paraStr收费时间;
            //this.m_DicOf一行购药药品记录 = paraDicOf一行购药药品记录;

            this.button_取消.Text = "关闭";
            this.button_确定.Visible = false;
            this.ShowDialog();
        }


        private void button_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_确定_Click(object sender, EventArgs e)
        {
            this.save一次购药记录保存文件();
            yzk_购药计算Manager.getInstance().Del所有行();
            yzk_购药计算Manager.getInstance().Del个人信息();
            this.Close();
        }

        private void save一次购药记录保存文件()
        {
            String tmp要存储的字符串 = this.Get要存储的字符串();

            String tmp文件名称 = DateTime.Now.ToString("yyyy_MM_dd");

            String tmp文件路径 = Application.StartupPath + @"\..\..\yzk_Log\";

            String tmp文件全路径名称 = tmp文件路径 + tmp文件名称;
            if (File.Exists(tmp文件名称))
            {
                
                using (FileStream fs = new FileStream(tmp文件全路径名称, FileMode.Append))
                {
                    using (StreamWriter tw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        tw.WriteLine(tmp要存储的字符串);
                    }
                }
            }
            else
            {
                using (FileStream fs = new FileStream(tmp文件全路径名称, FileMode.Append))
                {
                    using (StreamWriter tw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        tw.WriteLine(tmp要存储的字符串);
                    }
                }
            }
        }

        private String Get要存储的字符串()
        {
            String tmp总信息 = String.Empty;
            String tmp基本信息 = String.Empty;
            String tmp药品列表信息 = String.Empty;

            tmp基本信息 = this.m_Str收费时间 + "〦" + this.m_Str姓名 + "〦" + this.m_Str性别 + "〦" + this.m_Str年龄 + "〦" + this.m_Str电话+ "〦" + this.m_Str总额 + "〦" + this.m_DicOf一行购药药品记录.Count.ToString();

            foreach (KeyValuePair<String, yzk_一行购药药品记录> tmpKVP in this.m_DicOf一行购药药品记录)
            {
                String tmp一个药品 = String.Empty;
                tmp一个药品 = tmpKVP.Value.Get药品名称() + "〦" + tmpKVP.Value.GetStr单价() + "〦" + tmpKVP.Value.GetStr数量() + "〦" + tmpKVP.Value.GetStr金额();
                if (tmp药品列表信息.Equals(String.Empty))
                {
                    tmp药品列表信息 = tmp一个药品;
                }
                else
                {
                    tmp药品列表信息 += "〧" + tmp一个药品;
                }
            }

            tmp总信息 = tmp基本信息 + "〨" + tmp药品列表信息;

            return tmp总信息;
        }
    }
}
