using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yzk_clinic.yzk_收费记录
{
    class yzk_收费记录Manager
    {

        #region 单例模式
        /// <summary>
        /// 线程同步对象。初始化instance时线程同步。
        /// </summary>
        public static readonly object synRootOneInstance = new object();
        private static yzk_收费记录Manager instance = null;
        public static yzk_收费记录Manager getInstance()
        {
            //双重锁定
            if (null == instance)
            {
                lock (synRootOneInstance)
                {
                    if (null == instance)
                    {
                        instance = new yzk_收费记录Manager();
                    }
                }
            }
            return instance;
        }

        
        private yzk_收费记录Manager()
        {
            
        }

        private UserControl_收费记录 m_收费记界面 = null;
        internal void Init界面初始化(Panel paraPanel_主)
        {
            this.m_收费记界面 = new UserControl_收费记录();
            paraPanel_主.Controls.Add(this.m_收费记界面);
            this.m_收费记界面.Dock = DockStyle.Fill;
            this.Hide_自定义();
        }

        internal void Hide收费记录界面()
        {
            this.Hide_自定义();
        }

        private void Hide_自定义()
        {
            this.m_收费记界面.Hide();
        }

        internal void Display收费记录界面()
        {
            this.Display_自定义();
        }

        private void Display_自定义()
        {
            this.m_收费记界面.Show();
        }

        #endregion
    }
}
