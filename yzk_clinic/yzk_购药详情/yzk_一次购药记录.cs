using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yzk_clinic.yzk_收费记录;

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
        private String m_Str总额;

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

        /// <summary>
        /// 查询收费记录时用
        /// </summary>
        /// <param name="para姓名"></param>
        /// <param name="para性别"></param>
        /// <param name="para年龄"></param>
        /// <param name="para电话"></param>
        /// <param name="paraStr收费时间"></param>
        /// <param name="paraStr总额"></param>
        public yzk_一次购药记录(string para姓名, string para性别, string para年龄, string para电话, String paraStr收费时间, String paraStr总额)
        {
            this.m_姓名 = para姓名;
            this.m_性别 = para性别;
            this.m_年龄 = para年龄;
            this.m_电话 = para电话;
            //this.m_收费时间 = now;
            this.m_Str收费时间 = paraStr收费时间;
            this.m_Str总额 = paraStr总额;

            this.m_ListOf购药记录中的一种药.Clear();
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


            Form一次购药详情展示 tmp购药详情 = new Form一次购药详情展示(Enum_购药详细信息显示来源.m_购药时, this.m_姓名, this.m_性别, this.m_年龄, this.m_电话, this.m_Str收费时间, this.m_总额, this.m_DicOf一行购药药品记录);

        }

        /// <summary>
        /// 用于收费记录查询时
        /// </summary>
        public List<yzk_购药记录中的一种药> m_ListOf购药记录中的一种药 = new List<yzk_购药记录中的一种药>();

        internal void Add添加购药记录中的一种(yzk_购药记录中的一种药 para一种药)
        {
            this.m_ListOf购药记录中的一种药.Add(para一种药);
        }

        internal object Get收费时间_查询()
        {
            return this.m_Str收费时间;
        }

        internal string GetStr购药人姓名_查询()
        {
            return this.m_姓名;
        }

        internal string GetStr金额_查询()
        {
            return this.m_Str总额;
        }

        internal List<yzk_购药记录中的一种药> GetListOf购药记录中的一种药()
        {
            return this.m_ListOf购药记录中的一种药;
        }

        internal string GetStr性别_查询()
        {
            return this.m_性别;
        }

        internal string GetStr年龄_查询()
        {
            return this.m_年龄;
        }

        internal string GetStr电话_查询()
        {
            return this.m_电话;
        }

        internal string GetStr收费时间_查询()
        {
            return this.m_Str收费时间;
        }


        internal string GetStr总额_查询()
        {
            return this.m_Str总额;
        }

    }
}
