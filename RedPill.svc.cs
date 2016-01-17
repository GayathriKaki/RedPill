using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RedPill.Model;
using RedPill.Services;

namespace RedPill
{
   [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")] 
     public class RedPill : IRedPill
    { 
         private FibonacciService _fibonacciService; 
         private TriangleService _triangleService; 
         private ReverseWordsService _reverseWordsService; 
 
         public FibonacciService FibonacciService 
         { 
             get 
             { 
                 if (_fibonacciService == null) 
                 { 
                     _fibonacciService = new FibonacciService(); 
                 } 
                 return _fibonacciService; 
             } 
         } 


         public TriangleService TriangleService
         { 
             get 
             { 
                 if (_triangleService == null) 
                 { 
                     _triangleService = new TriangleService(); 
                 } 
                 return _triangleService; 
             } 
         } 
 

         public ReverseWordsService ReverseWordsService
         { 
             get 
             { 
                 if (_reverseWordsService == null) 
                 { 
                     _reverseWordsService = new ReverseWordsService(); 
                 } 
                 return _reverseWordsService; 
             } 
         } 
 
 
         public Guid WhatIsYourToken()
         { 
             return new Guid("64bcdf73-3359-41a3-ac70-416e4ba330d0"); 
         } 
 
 
         public long FibonacciNumber(long n)
         { 
             try 
             { 
                 return FibonacciService.GetNum(n); 
             } 
             catch (ArgumentOutOfRangeException e) 
             { 
                 throw new FaultException<ArgumentOutOfRangeException>(e, e.Message); 
             } 
              
         } 
 
 
         public TriangleType WhatShapeIsThis(int a, int b, int c)
         { 
             return TriangleService.GetType(a, b, c); 
         } 
 
 
         public string ReverseWords(string s)
         { 
             try 
             { 
                 return ReverseWordsService.ReverseWords(s); 
             } 
             catch (ArgumentNullException e) 
             { 
 
 
                 throw new FaultException<ArgumentNullException>(e,e.Message); 
             } 
              
         } 
     } 

 
      

}
