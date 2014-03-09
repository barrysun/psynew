using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class QueryType
    {
       public string lxToQuery(string lx)
       {
           if (lx == "zrc")
           {
               return "找人才";
           }
           else if (lx == "zgz")
           {
               return "找工作";
           }
           return "";
       }
       /// <summary>
       /// 薪资
       /// </summary>
       /// <param name="xz"></param>
       /// <returns></returns>
       public string xinziToQuery(string xz)
       {
           if (xz == "1") return "1000以下元/月";
           if (xz == "2") return "1000~2000元/月";
           if (xz == "3") return "2000~3000元/月";
           if (xz == "4") return "3000~5000元/月";
           if (xz == "5") return "5000~10000元/月";
           if (xz == "6") return "10000以上元/月";
           if (xz == "7") return "面议";
           if (xz == "0") return "不限";
           return "";
       }
       /// <summary>
       /// 工作性质
       /// </summary>
       /// <param name="gzxz"></param>
       /// <returns></returns>
       public string gzxzToQuery(string gzxz)
       {
           if (gzxz == "1") return "";
           return "";
       }
       /// <summary>
       /// 性别
       /// </summary>
       /// <param name="xb"></param>
       /// <returns></returns>
       public string xbToQuery(string xb)
       {
           return "";
       }
       /// <summary>
       /// 学历
       /// </summary>
       /// <param name="xl"></param>
       /// <returns></returns>
       public string xlToQuery(string xl)
       {
           return "";
       }
       /// <summary>
       /// 工作经验
       /// </summary>
       /// <param name="gzjy"></param>
       /// <returns></returns>
       public string gzjyToQuery(string gzjy)
       {
           return "";
       }
       /// <summary>
       /// 目前状态
       /// </summary>
       /// <param name="zt"></param>
       /// <returns></returns>
       public string ztToQuery(string zt)
       {
           return "";
       }

    }
}
