using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Dal
{
   public  class JobViewDal
    {
       public DataTable getbyNode(int node) {
           string sql = "select * from jobview where NODE=" + node;
           return new MySQLHelper().GetDataTable(sql);
       
       }

       public DataTable getJobIdByTitle(string title)
       {
           string sql = "select JOBID from jobview where TITLE='" + title + "'";
           return new MySQLHelper().GetDataTable(sql);
       }
    }
}
