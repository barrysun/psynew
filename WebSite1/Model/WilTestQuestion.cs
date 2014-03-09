using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
  public   class WilTestQuestion
    {
      public int WilId { get; set; }
      public string WilType { get; set; }
      public string LetterMark { get; set; }
      public string WilTitle { get; set; }
      public float ImportScore { get; set; }
      public float SecondlyScore { get; set; }
      public float GeneralScore { get; set; }
      public float SomeimportScore { get; set; }
      public float NotinportScore { get; set; }
      public int WilOrder { get; set; }
    }
}
