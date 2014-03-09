using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Dal
{
   public  class JobMapBinaryDal
    {

       public double[] getJobIDList(string columns) {
           var sql = "select " + columns + " from jobmapbinary  order by jobid";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           double[] re=null;
           if (dt != null && dt.Rows.Count > 0)
           { 
               re=new double[dt.Rows.Count];
               for (var i = 0; i < dt.Rows.Count; i++)
               {
                   re[i] = double.Parse(dt.Rows[i][columns].ToString());
               }
           }
           return re;
       }
       public DataTable getByJobId(String jobId) {

           var sql = "select JOBMAPID,JOBID,SYL01B,SYL02B,SYL03B,SYL04B,SYL05B,SYL06B,SYL07B,SYL08B,SYL09B,SYL10B," +
               "SYL11B,SYL12B,SYL13B,SYL14B,SYL15B,SYL16B,SKL01B,SKL11B,SKL19B,SKL21B,SKL30B from jobmapbinary where JOBID=" + jobId + " order by JOBID";
           return new MySQLHelper().GetDataTable(sql);
       }




    }
}
