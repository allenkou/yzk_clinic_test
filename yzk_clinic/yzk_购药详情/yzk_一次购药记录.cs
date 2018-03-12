using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yzk_clinic.yzk_购药详情
{
    public class yzk_一次购药记录
    {
        private string m_姓名;
        private string m_性别;
        private string m_年龄;
        private string m_电话;
        private System.DateTime m_收费时间;
        private string m_Str收费时间;
        private double m_总额;

        public Dictionary<String, yzk_一行购药药品记录> m_DicOf一行购药药品记录 = new Dictionary<string, yzk_一行购药药品记录>();
        

        public yzk_一次购药记录(string para姓名, string para性别, string para年龄, string para电话, DateTime now)
        {
            this.m_姓名 = para姓名;
            this.m_性别 = para性别;
            this.m_年龄 = para年龄;
            this.m_电话 = para电话;
            this.m_收费时间 = now;
            this.m_Str收费时间 = this.m_收费时间.ToString("yyyy-MM-dd HH:mm:ss");

        }

        internal void Show窗口_自定义()
        {
            double tmp总额 = 0;
            #region 计算总额
            foreach (KeyValuePair<String, yzk_一行购药药品记录> tmpKVP in this.m_DicOf一行购药药品记录)
            {
                tmp总额 += tmpKVP.Value.Get总额();
            }
            this.m_总额 = tmp总额;
            #endregion


            Form一次购药详情展示 tmp购药详情 = new Form一次购药详情展示(this.m_姓名, this.m_性别, this.m_年龄, this.m_电话, this.m_Str收费时间, this.m_总额, this.m_DicOf一行购药药品记录);

        }
    }
}
