using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
  public class IpTestQuestion
    {
      public int IpId { get; set; }
      public string IpType { get; set; }
      public string IpTitle { get; set; }
      public float LikeScore { get; set; }
      public float NotLikeScore { get; set; }
      public float UncertainScore { get; set; }
      public int IpOrder { get; set; }
    }
}
