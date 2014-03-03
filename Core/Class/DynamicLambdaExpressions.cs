using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relation.Core.Class
{
   public class DynamicLambdaExpressions
    {
       public static string strNameLowerContains
       {
           get
           {
               return @"strName.ToLower().Contains(@0)";
           }
       }

       public static string LowerContains(string columnName)
       {
           return columnName + ".ToLower().Contains(@0)";
       }
    }
}
