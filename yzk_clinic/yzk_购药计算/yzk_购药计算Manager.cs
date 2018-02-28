using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yzk_clinic.yzk_控件;

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

        internal void Hide购药计算界面()
        {
            this.Hide_自定义();
        }

        private void Display_自定义()
        {
            this.m_购药计算界面.Show();
        }

        internal void Init界面初始化(Panel paraPanel_主)
        {
            this.m_购药计算界面 = new UserControl_购药计算();
            paraPanel_主.Controls.Add(this.m_购药计算界面);
            this.m_购药计算界面.Dock = DockStyle.Fill;
            this.Hide_自定义();
        }

        private void Hide_自定义()
        {
            this.m_购药计算界面.Hide();
        }

        UserControl_购药计算 m_购药计算界面 = null;
        private yzk_购药计算Manager()
        {
        }
        #endregion
    }
}
