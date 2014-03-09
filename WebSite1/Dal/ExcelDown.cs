using System;
using System.Collections.Generic;

using System.Text;
using System.Web;
using org.in2bits.MyXls;
using System.Data;
using System.IO;

namespace Dal
{
   public  class ExcelDown
    {
       public void downExcel(HttpResponse response,DataTable dt,string fileName,string path)
       {
           XlsDocument xls = new XlsDocument();//新建一个
           xls.FileName = fileName + ".xls";
           Worksheet sheet = xls.Workbook.Worksheets.Add("Sheet1");
           //填充表头
           try
           {
               foreach (DataColumn col in dt.Columns)
               {
                   sheet.Cells.Add(1, col.Ordinal + 1, col.ColumnName);
               }
               //填充内容
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   for (int j = 0; j < dt.Columns.Count; j++)
                   {
                       sheet.Cells.Add(i + 2, j + 1, dt.Rows[i][j].ToString());
                   }
               }


               #region
               using (MemoryStream ms = new MemoryStream())
               {
                   xls.Save(ms);
                   ms.Flush();
                   ms.Position = 0;
                   sheet = null;
                   xls = null;
                   // HttpResponse response = System.Web.HttpContext.Current.Response;
                   response.Clear();
                   response.Charset = "UTF-8";
                   response.ContentType = "application/vnd-excel";//"application/vnd.ms-excel";
                   System.Web.HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment; filename=" + fileName + ".xls"));
                   //System.Web.HttpContext.Current.Response.WriteFile(fi.FullName);
                   byte[] data = ms.ToArray();
                   System.Web.HttpContext.Current.Response.BinaryWrite(data);

               }
               #endregion
           }
           finally {
               sheet = null;
               xls = null;
           }
       }


    }
}
