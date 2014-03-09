using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
   public  class ForecastReportComponent
    {
       public int ForecastRepCompId { get; set; }
       public int YcNum { get; set; }
       public string Variable { get; set; }
       public int VariableValue { get; set; }
       public string ReportComponent { get; set; }
    }
}
