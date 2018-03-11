using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yzk_clinic.yzk_购药计算
{
    class yzk_一种药
    {
        private string m_名称;
        private double m_单价;
        /// <summary>
        /// yzkou自己加的，目前没有什么意义
        /// </summary>
        private int m_序号;

        public yzk_一种药(string tmp名称, double tmp单价)
        {
            this.m_名称 = tmp名称;
            this.m_单价 = tmp单价;
        }
    }
}
