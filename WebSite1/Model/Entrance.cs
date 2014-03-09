using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
    /// <summary>
    /// 高考类
    /// </summary>
  public   class Entrance
    {
      public int Id { get; set; }
      public string Title { get; set; }
      public int EntranceType { get; set; }
      public string Content { get; set; }
      public DateTime EditTime { get; set; }
      public int IsHome { get; set; }
      public int Order { get; set; }
    }
}
