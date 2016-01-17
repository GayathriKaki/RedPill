using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Runtime.Serialization; 
 using System.ServiceModel; 
 using System.ServiceModel.Web; 
 using System.Text; 
 using RedPill.Model;


namespace RedPill
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRedPill" in both code and config file together.
     [ServiceContract(Namespace = "http://KnockKnock.readify.net", Name = "IRedPill")] 
     public interface IRedPill
     { 
 
 
         [OperationContract] 
         [WebGet(UriTemplate = "WhatIsYourToken")] 
         Guid WhatIsYourToken(); 
 
 
         [FaultContract(typeof(ArgumentOutOfRangeException))] 
         [OperationContract] 
         [WebGet(UriTemplate = "FibonacciNumber/{n}")] 
         long FibonacciNumber(long n); 
 
 
         [OperationContract] 
         [WebGet] 
         TriangleType WhatShapeIsThis(int a, int b, int c); 
 
 
         [OperationContract] 
         [FaultContract(typeof(ArgumentNullException))] 
         [WebGet] 
         string ReverseWords(string s); 
     } 

}
