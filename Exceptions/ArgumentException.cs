using System; 
 using System.Collections.Generic; 
using System.Linq; 
 using System.Runtime.Serialization; 
 using System.Web;

namespace RedPill.Exceptions
{
    [DataContract] 
     [KnownType(typeof(ArgumentNullException))] 
     [KnownType(typeof(ArgumentOutOfRangeException))] 
     public class ArgumentException : SystemException 
     { 
     }

}