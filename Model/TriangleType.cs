using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Runtime.Serialization; 
 using System.Web; 
 
 


namespace RedPill.Model
{
    [DataContract(Namespace = "http://KnockKnock.readify.net")] 
     public enum TriangleType
     { 
         [EnumMember] 
         Error, 
 
 
         [EnumMember] 
         Equilateral, 
 

         [EnumMember] 
         Isosceles, 
 
 
         [EnumMember] 
         Scalene, 
     } 

}
