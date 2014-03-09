using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
   public  class IpAnswer
    {
       public int UserId { get; set; }
       public int IpId { get; set; }
       public string Answer { get; set; }
       public float Score { get; set; }
    }
}
