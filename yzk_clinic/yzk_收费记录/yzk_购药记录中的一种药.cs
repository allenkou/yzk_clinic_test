using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yzk_clinic.yzk_收费记录
{
    public class yzk_购药记录中的一种药
    {
        private string m_Str药名;
        private string m_Str单价;
        private string m_Str数量;
        private string m_Str金额;

        public yzk_购药记录中的一种药(string v1, string v2, string v3, string v4)
        {
            this.m_Str药名 = v1;
            this.m_Str单价 = v2;
            this.m_Str数量 = v3;
            this.m_Str金额 = v4;
        }

        internal object Get药品名称()
        {
            return this.m_Str药名;
        }

        internal object GetStr金额()
        {
            return this.m_Str金额;
        }

        internal object GetStr数量()
        {
            return this.m_Str数量;
        }

        internal object GetStr单价()
        {
            return this.m_Str单价;
        }
    }
}
