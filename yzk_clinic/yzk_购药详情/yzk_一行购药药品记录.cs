using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yzk_clinic.yzk_购药详情
{
    public class yzk_一行购药药品记录
    {
        private string m_Str药品名称;
        private double m_Double单价g;
        private int m_Int数量g;
        private double m_Double金额;
        

        public yzk_一行购药药品记录(string tmpStr药品名称, double tmpDouble单价g, int tmpInt数量g)
        {
            this.m_Str药品名称 = tmpStr药品名称;
            this.m_Double单价g = tmpDouble单价g;
            this.m_Double金额 = tmpInt数量g;
            this.m_Double金额 = this.m_Double单价g * this.m_Double金额;
        }

        internal double Get总额()
        {
            return this.m_Double金额;
        }
    }
}
