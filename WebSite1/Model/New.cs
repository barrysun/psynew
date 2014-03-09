using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
    /// <summary>
    /// 新闻动态
    /// </summary>
   public  class New
    {
       public int Id { get; set; }
       public string NewTitle { get; set; }
       public DateTime EditTime { get; set; }
       public string NewContent { get; set; }
       public int NewType { get; set; }
       public string PICUrl { get; set; }
       public int NewOrder { get; set; }
       public int IsHome { get; set; }
    }
}
