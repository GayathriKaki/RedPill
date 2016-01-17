using System; 
 using System.Collections.Generic; 
 using System.Linq; 
using System.Runtime.Serialization; 
 using System.Security.Permissions; 
 using System.Web;

namespace RedPill.Exceptions
{
   [DataContract] 
     [KnownType(typeof(ArgumentException))] 
     [KnownType(typeof(ArgumentNullException))] 
     [KnownType(typeof(ArgumentOutOfRangeException))] 
     public class SystemException
     { 
          
    } 

}