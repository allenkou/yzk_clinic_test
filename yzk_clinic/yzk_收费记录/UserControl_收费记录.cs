using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace yzk_clinic.yzk_收费记录
{
    public partial class UserControl_收费记录 : UserControl
    {
        public UserControl_收费记录()
        {
            InitializeComponent();
        }

        private List<String> m_ListOf日志记录文件名称 = new List<string>();

        private void button_查询_Click(object sender, EventArgs e)
        {
            this.m_ListOf日志记录文件名称.Clear();
            DateTime tmp开始 = this.dateTimePicker_开始.Value.Date;
            DateTime tmp结束 = this.dateTimePicker_结束.Value.Date;
            if (tmp开始 > tmp结束)
            {
                MessageBox.Show("开始时间需要早于结束时间", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tmp结束 > DateTime.Now.Date)
            {
                tmp结束 = DateTime.Now.Date;
            }

            if (tmp开始 > tmp结束)
            {
                MessageBox.Show("开始时间需要早于当前时间", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            for (; tmp开始 <= tmp结束; tmp开始 = tmp开始.AddDays(1))
            {
                this.m_ListOf日志记录文件名称.Add(tmp开始.ToString("yyyy_MM_dd"));
            }

            this.GetAndShow查询到的所有记录();
        }

        private void GetAndShow查询到的所有记录()
        {
            foreach (String tmp文件名 in this.m_ListOf日志记录文件名称)
            {
                try
                {
                    String tmpStr全路径文件名 = Application.StartupPath + @"\..\..\yzk_Log\" + tmp文件名;
                    if (!File.Exists(tmpStr全路径文件名))
                    {
                        continue;
                    }

                    using (StreamReader sr = new StreamReader(tmpStr全路径文件名, Encoding.Unicode, true))
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
                            
                        }
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
        }
    }
}
