using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RedPill.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReverseWordsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ReverseWordsService.svc or ReverseWordsService.svc.cs at the Solution Explorer and start debugging.
    public class ReverseWordsService
    {
        public string ReverseWords(string sentence)
        {
            if (sentence == null)
            {
                throw new ArgumentNullException();
            }


            var words = sentence.Split(' ').Select(ReverseWord);
            return string.Join(" ", words);
        }


        public string ReverseWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return word;
            }
            var item = string.Join("", word.Reverse());


            return item;
        }
    }

}

