using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
    /// <summary>
    /// 导航栏
    /// 友情链接
    /// </summary>
  public  class Navigation
    {
      public int Id { get; set; }
      public int ParentId { get; set; }
      public string Url { get; set; }
      public string URLName { get; set; }
      public int URLType { get; set; }
      public string Des { get; set; }
      public int Order { get; set; }
    }
}
