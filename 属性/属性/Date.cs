using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 属性
{
 public   class Date
    {
     private int month = 7;
     public int Month
     {
         get
         {
             return month;
         }
      //   Month 是作为属性声明的，这样set访问 访问
      //   器可确保 器可确保Month 值设置在0 和12
         set
         {
             if ((value > 0) && (value <= 12))
             {
                 month = value;
             }
         }
     }
    }
}
