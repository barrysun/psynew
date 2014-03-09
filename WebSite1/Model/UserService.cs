using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
    /// <summary>
    /// 会员服务
    /// </summary>
   public  class UserService
    {
       public int Id { get; set; }
       public string Title { get; set; }
       public string Des { get; set; }
       public DateTime InDate { get; set; }
       public DateTime BeginDate { get; set; }
       public DateTime EndDate { get; set; }
       public int IsHome { get; set; }
       public int Order { get; set; }
    }
}
