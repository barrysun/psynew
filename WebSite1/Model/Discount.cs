using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
  public   class Discount
    {
        public int Id { get;set; }
        public string DiscountName{get;set;}
        public float DiscountCount{get;set;}
    }

    public class Changping
    {
        public int Id{get;set;}
        public string ChangpingName{get;set;}
        public string Des{get;set;}
        public float Unitprice { get; set; }
        public int UserCompy { get; set; }
    
    }

    public class ShoppingCar
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Changping { get; set; }
        public int Discount { get; set; }
        public DateTime ShoppingTime { get; set; }
        public int IsPay { get; set; }
        public int ChangPingCount { get; set; }
        public float Money { get; set; }
    }

}
