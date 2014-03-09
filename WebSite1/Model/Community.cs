using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
   public  class Community
    {
       public int Id { get; set; }
       public string Title { get; set; }
       public int Type { get; set; }
       public string Content { get; set; }
       public DateTime EditTime { get; set; }
       public int IsHome { get; set; }
       public int Order { get; set; }
    }
}
