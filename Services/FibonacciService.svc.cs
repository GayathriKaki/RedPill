using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RedPill.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FibonacciService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FibonacciService.svc or FibonacciService.svc.cs at the Solution Explorer and start debugging.
    public class FibonacciService
    {
      public long GetNum(long index)
         {            
             if (index == 0) 
             { 
                 return 0; 
             } 
 
 
             if (index >= int.MaxValue || index <= int.MinValue) 
             { 
                 throw new ArgumentOutOfRangeException(); 
             } 
 
 
             if (index > 0) 
             { 
                 if (index <= 2) 
                 { 
                     return 1; 
                 } 
 
 
                 var k = (index) / 2; 
                 var a = GetNum(k + 1); 
                 var b = GetNum(k); 
 
 
                 if (index%2 == 1) 
                 { 
                     return (a* a + b* b); 
                 } 
                 else 
                 { 
                     return b* (2 * a - b); 
                 } 
             } 
             else 
             { 
                 if (index%2 == 0) 
                 { 
                     return -GetNum(-index); 
                 } 
                 else 
                 { 
                     return GetNum(-index); 
                 } 
             }             
         } 
     } 

    }

