using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
    /// <summary>
    /// 专家团队
    /// </summary>
  public   class Expert
    {
      public int Id { get; set; }
      public string ExpertName { get; set; }
      public string ExpertPhoto { get; set; }
      public string ExpertDes { get; set; }
      public int ExpertType { get; set; }
      public int Order { get; set; }
    }
}
