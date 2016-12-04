using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLibrary
{
   public class Question
    {
        public int num { get; set; }
       public string question { get; set; }
       public string tru { get; set; }
       public string a1 { get; set; }
       public string a2 { get; set; }
       public string alta { get; set; }
        List<string> ListAnswers = new List<string>();
        public Question(string q,string _tru,string a1,string a2)
        {
            question = q;
            tru = _tru;
            this.a1 = a1;
            this.a2 = a2;
       }
        public Question() { }
        public Question(string alt)
        {
            alta = alt;
        }
        public string truRes(bool t)
        {
            return tru;
        }
    }
}
