using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Culc
    {
        public string a { get; set; }
        public string b { get; set; }
        public Culc()
        {

        }
        public string Positive(string a,string b)
        {
            int A = Int32.Parse(a);
            int B = Int32.Parse(b);
            return (A + B).ToString();
        }
        public string Negative(string a, string b)
        {
            int A = Int32.Parse(a);
            int B = Int32.Parse(b);
            return (A-B).ToString();
        }
        public string Multiply(string a, string b)
        {
            int A = Int32.Parse(a);
            int B = Int32.Parse(b);
            return (A * B).ToString();
        }
        public string Division(string a, string b)
        {
            int A = Int32.Parse(a);
            int B = Int32.Parse(b);
            return (A / B).ToString();
        }
    }
}
