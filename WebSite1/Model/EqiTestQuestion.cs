using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
   public  class EqiTestQuestion
    {
       public int EqiId { get; set; }
       public string EqiType { get; set; }
       public int OriginalNumber { get; set; }
       public string Test { get; set; }
       public int TestNumber { get; set; }
       public double Score { get; set; }
       public string SpecialType { get; set; }
       public int IsUse { get; set; }
       public string EqiTitle { get; set; }
       public int EqiOrder { get; set; }
       public double VeryScore { get; set; }
       public double BasicScore { get; set; }
       public double SomeTimeScore { get; set; }
       public double DoesnotScore { get; set; }
       public double NotScore { get; set; }
    }
}
