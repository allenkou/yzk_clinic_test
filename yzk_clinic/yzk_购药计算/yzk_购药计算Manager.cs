using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzk_clinic.yzk_控件;
using yzk_clinic.yzk_购药详情;

namespace yzk_clinic.yzk_购药计算
{
    class yzk_购药计算Manager
    {
        #region 单例模式
        /// <summary>
        /// 线程同步对象。初始化instance时线程同步。
        /// </summary>
        public static readonly object synRootOneInstance = new object();
        private static yzk_购药计算Manager instance = null;
        public static yzk_购药计算Manager getInstance()
        {
            //双重锁定
            if (null == instance)
            {
                lock (synRootOneInstance)
                {
                    if (null == instance)
                    {
                        instance = new yzk_购药计算Manager();
                    }
                }
            }
            return instance;
        }

        internal void Display购药计算界面()
        {
            this.Display_自定义();
        }

        internal string Get药品单价(string para药品名称)
        {
            yzk_一种药 tmpKK = this.m_DicOf药品[para药品名称];
            return tmpKK.Get药品单价();
        }

        internal void Hide购药计算界面()
        {
            this.Hide_自定义();
        }

        

        internal void Init界面初始化(Panel paraPanel_主)
        {
            this.m_购药计算界面 = new UserControl_购药计算();
            paraPanel_主.Controls.Add(this.m_购药计算界面);
            this.m_购药计算界面.Dock = DockStyle.Fill;
            this.Hide_自定义();
        }

        internal void Display收费详情(string para姓名, string para性别, string para年龄, string para电话)
        {
            //Form一次购药详情展示 tmp购药详情 = new Form一次购药详情展示();

            yzk_一次购药记录 tmp一次购药记录 = new yzk_一次购药记录(para姓名, para性别, para年龄, para电话, DateTime.Now);

            foreach (UserControl_单个药品输入 tmpKK in this.m_ListOf单个药品输入控件)
            {
                String tmpStr药品名称 = tmpKK.GetStr药品名称();
                if (tmpStr药品名称.Equals(String.Empty))
                {
                    MessageBox.Show("有空的药品名称", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!this.m_ListOf药品名称.Contains(tmpStr药品名称))
                {
                    MessageBox.Show("不存在的药品名称 " + tmpStr药品名称, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Double tmpDouble单价g = this.GetDouble药品单价(tmpStr药品名称);

                int tmpInt数量g = 0;
                String tmpStr药品数量 = tmpKK.GetStr药品数量g();
                if (!Int32.TryParse(tmpStr药品数量, out tmpInt数量g))
                {
                    MessageBox.Show(tmpStr药品名称 + " 药品数量不对 " + tmpStr药品数量, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (0 == tmpInt数量g)
                {
                    MessageBox.Show(tmpStr药品名称 + " 药品数量为0 " + tmpStr药品数量, "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                yzk_一行购药药品记录 tmp一行购药药品记录 = new yzk_一行购药药品记录(tmpStr药品名称, tmpDouble单价g, tmpInt数量g);

                if (tmp一次购药记录.m_DicOf一行购药药品记录.ContainsKey(tmpStr药品名称))
                {
                    MessageBox.Show(tmpStr药品名称 + " 药品重复 ", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tmp一次购药记录.m_DicOf一行购药药品记录.Add(tmpStr药品名称, tmp一行购药药品记录);

            }

            if (tmp一次购药记录.m_DicOf一行购药药品记录.Count == 0)
            {
                MessageBox.Show(" 没有购药 ", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tmp一次购药记录.Show窗口_自定义();

        }

        internal void Del个人信息()
        {
            this.m_购药计算界面.Del个人信息();
        }

        internal void Del所有行()
        {
            foreach (UserControl_单个药品输入 tmpKK in this.m_ListOf单个药品输入控件)
            {
                this.m_购药计算界面.Del单个药品输入控件_自定义(tmpKK);
                //this.m_ListOf单个药品输入控件.Remove(tmpKK);
                //this.m_Int药品列表控件数 = this.m_ListOf单个药品输入控件.Count;
            }

            this.m_ListOf单个药品输入控件.Clear();
            this.m_Int药品列表控件数 = this.m_ListOf单个药品输入控件.Count;
            this.Display_自定义();

        }

        private void Hide_自定义()
        {
            this.m_购药计算界面.Hide();
        }

        UserControl_购药计算 m_购药计算界面 = null;
        private yzk_购药计算Manager()
        {
            this.init药品初始();
        }
        
        #endregion

        Dictionary<String, yzk_一种药> m_DicOf药品 = new Dictionary<string, yzk_一种药>();
        public List<String> m_ListOf药品名称 = new List<string>();
        public List<UserControl_单个药品输入> m_ListOf单个药品输入控件 = new List<UserControl_单个药品输入>();

        internal void Add新一行()
        {
            if (this.m_ListOf单个药品输入控件.Count >= 20)
            {
                MessageBox.Show("药品最多20项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserControl_单个药品输入 tmp单个药品输入控件 = null;
            this.m_购药计算界面.Add单个药品输入控件_自定义(out tmp单个药品输入控件);
            this.m_ListOf单个药品输入控件.Add(tmp单个药品输入控件);
            this.m_Int药品列表控件数 = this.m_ListOf单个药品输入控件.Count;
        }

        int m_Int药品列表控件数 = 0;

        private void init药品初始()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                //using (StreamReader sr = new StreamReader(Application.StartupPath + @"\..\yzk_config" + @"\药品配置.txt", Encoding.GetEncoding(54936), true))
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\..\..\yzk_config" + @"\药品配置.txt", Encoding.Default, true))
                {
                    String line;
                    string[] col;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("#"))
                        {
                            continue;
                        }
                        //Console.WriteLine(line);
                        char[] sep = new char[3];
                        sep[0] = ',';
                        sep[1] = '\t';
                        sep[2] = '/';

                        col = line.Split(sep, 9, StringSplitOptions.RemoveEmptyEntries);
                        if (col.Length < 2)
                        {
                            continue;
                        }
                        String tmp名称 = col[1];
                        Double tmp单价 = 0;
                        if (!Double.TryParse(col[2], out tmp单价))
                        {
                            MessageBox.Show("药品单价读取错误： " + line, "启动错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(0);
                        }
                        yzk_一种药 tmp一种药 = new yzk_一种药(tmp名称, tmp单价);

                        this.m_ListOf药品名称.Add(tmp名称);
                        this.m_DicOf药品.Add(tmp名称, tmp一种药);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                //Console.WriteLine("The file could not be read:");
                //Console.WriteLine(e.Message);
                
            }
        }

        internal void Del一行(UserControl_单个药品输入 para一行)
        {
            this.m_购药计算界面.Del单个药品输入控件_自定义(para一行);
            this.m_ListOf单个药品输入控件.Remove(para一行);
            this.m_Int药品列表控件数 = this.m_ListOf单个药品输入控件.Count;
        }

        internal Double GetDouble药品单价(string para药品名称)
        {
            yzk_一种药 tmpKK = this.m_DicOf药品[para药品名称];
            return tmpKK.GetDouble药品单价();
        }

        private void Display_自定义()
        {
            if (0 == this.m_Int药品列表控件数)
            {
                //UserControl_单个药品输入 tmp单个药品输入控件 = null;
                //this.m_ListOf单个药品输入控件.Add(tmp单个药品输入控件);
                //this.m_购药计算界面.Add单个药品输入控件_自定义(tmp单个药品输入控件);
                UserControl_单个药品输入 tmp单个药品输入控件 = null;
                this.m_购药计算界面.Add单个药品输入控件_自定义(out tmp单个药品输入控件);
                this.m_ListOf单个药品输入控件.Add(tmp单个药品输入控件);
                this.m_Int药品列表控件数 = this.m_ListOf单个药品输入控件.Count;
            }
            this.m_购药计算界面.Show();
        }

    }
}
