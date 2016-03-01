using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RedPill.Model;

namespace RedPill.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TriangleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TriangleService.svc or TriangleService.svc.cs at the Solution Explorer and start debugging.
    public class TriangleService {
        public TriangleType GetTriaType(int a, int b, int c)
         { 
             if (a <= 0 || b <= 0 || c <= 0) 
             { 
                 return TriangleType.Error; 
             } 
 
 
             if (a + b <= c || a + c <= b || b + c <= a) 
             { 
                 return TriangleType.Error; 
             } 
 
 
             if (a == b && b == c) 
             { 
                 return TriangleType.Equilateral; 
             } 
 
 
             if (a == b || b == c || a == c) 
             { 
                 return TriangleType.Isosceles; 
             } 
 
 
             return TriangleType.Scalene; 
         } 

    }
}
