using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLibrary
{
    public class Result
    {
        public string username { get; set; }
        public ushort result { get; set; } 
        public ushort trying { get; set; }
        public string date { get; set; }
        public string answeredQ { get; set; }
        public ushort sumQuestions { get; set; }
        public Result() { }

        public Result(string username, ushort result, ushort trying, string date,string answered,ushort sumQ)
        {
            this.username = username;
            this.result = result;
            this.trying = trying;
            this.date = date;
            answeredQ = answered;
            sumQuestions = sumQ;
        }
    }
}
