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
using yzk_clinic.yzk_购药详情;
using yzk_clinic.yzk_购药计算;

namespace yzk_clinic.yzk_收费记录
{
    public partial class UserControl_收费记录 : UserControl
    {
        public UserControl_收费记录()
        {
            InitializeComponent();
        }

        private List<String> m_ListOf日志记录文件名称 = new List<string>();


        private List<yzk_一次购药记录> m_ListOf查询日期内的购药记录 = new List<yzk_一次购药记录>();
        private void button_查询_Click(object sender, EventArgs e)
        {
            this.m_ListOf日志记录文件名称.Clear();
            this.m_ListOf查询日期内的购药记录.Clear();
            this.dataGridView1.Rows.Clear();
            this.label_合计.Text = String.Empty;

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
            Double tmpDouble所有查询记录总金额 = 0;
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
                        string[] col基本信息;
                        string[] col药品列表;
                        string[] col单个药品信息;
                        // Read and display lines from the file until the end of 
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("#"))
                            {
                                continue;
                            }
                            //Console.WriteLine(line);
                            char[] sep = new char[1];
                            sep[0] = '〨';

                            col = line.Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);
                            if (col.Length < 2)
                            {
                                MessageBox.Show("收费记录读取错误: " + tmp文件名 + Environment.NewLine + line, "购药记录读取错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            char[] sep_1级 = new char[1];
                            sep_1级[0] = '〦';
                            col基本信息 = col[0].Split(sep_1级, 7);
                            if (col基本信息.Length < 7)
                            {
                                MessageBox.Show("收费记录基本信息读取错误: " + tmp文件名 + Environment.NewLine + line, "购药记录读取错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                            yzk_一次购药记录 tmp一次购药记录 = new yzk_一次购药记录(col基本信息[1], col基本信息[2], col基本信息[3], col基本信息[4], col基本信息[0], col基本信息[5]);

                            int tmpInt药品个数 = 0;
                            if (!Int32.TryParse(col基本信息[6], out tmpInt药品个数))
                            {
                                MessageBox.Show("收费记录药品个数读取错误: " + tmp文件名 + Environment.NewLine + line, "购药记录读取错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (0 == tmpInt药品个数)
                            {
                                MessageBox.Show("收费记录药品个数读取错误为0: " + tmp文件名 + Environment.NewLine + line, "购药记录读取错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            char[] sep_2级 = new char[1];
                            sep_2级[0] = '〧';
                            col药品列表 = col[1].Split(sep_2级, tmpInt药品个数);
                            if (col药品列表.Length < tmpInt药品个数)
                            {
                                MessageBox.Show("收费记录药品列表读取错误: " + tmp文件名 + Environment.NewLine + line, "购药记录读取错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            for (int kk = 0; kk < tmpInt药品个数; kk++)
                            {
                                col单个药品信息 = col药品列表[kk].Split(sep_1级, 4);
                                yzk_购药记录中的一种药 tmp一种药 = new yzk_购药记录中的一种药(col单个药品信息[0], col单个药品信息[1], col单个药品信息[2], col单个药品信息[3]);
                                tmp一次购药记录.Add添加购药记录中的一种(tmp一种药);
                            }

                            Double tmpDouble一个金额 = 0;

                            Double.TryParse(col基本信息[5], out tmpDouble一个金额);

                            tmpDouble所有查询记录总金额 += tmpDouble一个金额;
                            this.m_ListOf查询日期内的购药记录.Add(tmp一次购药记录);

                        }
                    }
                }
                catch (Exception e)
                {
                    
                }
            }
            this.Show查询到的所有记录(tmpDouble所有查询记录总金额.ToString());

            
        }

        private void Show查询到的所有记录(String paraStr总金额)
        {
            foreach (yzk_一次购药记录 tmpKK in this.m_ListOf查询日期内的购药记录)
            {
                int tmpIndex = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[tmpIndex].Cells[0].Value = tmpKK.Get收费时间_查询();
                this.dataGridView1.Rows[tmpIndex].Cells[1].Value = tmpKK.GetStr购药人姓名_查询();
                this.dataGridView1.Rows[tmpIndex].Cells[2].Value = tmpKK.GetStr金额_查询();
                this.dataGridView1.Rows[tmpIndex].Cells[3].Tag = tmpKK;
            }

            this.label_合计.Text = "￥" + paraStr总金额;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];

                if (column is DataGridViewButtonColumn)
                {
                    yzk_一次购药记录 tmpKK = (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag as yzk_一次购药记录);

                    if (null != tmpKK)
                    {
                        Form一次购药详情展示 tmp购药详情 = new Form一次购药详情展示(Enum_购药详细信息显示来源.m_查询时, tmpKK.GetStr购药人姓名_查询(), tmpKK.GetStr性别_查询(), tmpKK.GetStr年龄_查询(), tmpKK.GetStr电话_查询(), tmpKK.GetStr收费时间_查询(), tmpKK.GetStr总额_查询(), tmpKK.GetListOf购药记录中的一种药());
                    }
                }
            }
        }

        
    }
}
