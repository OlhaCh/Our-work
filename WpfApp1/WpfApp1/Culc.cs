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
            try
            {
                int A = Int32.Parse(a);
                int B = Int32.Parse(b);

                return (A + B).ToString();
            }
            catch (Exception e)
            {              
            }
            return "ERROR";

        }
        public string Negative(string a, string b)
        {
            try
            {
                int A = Int32.Parse(a);
                int B = Int32.Parse(b);
                return (A - B).ToString();
            }
            catch (Exception e)
            {
            }
            return "ERROR";
        }
        public string Multiply(string a, string b)
        {  try
            {
                int A = Int32.Parse(a);
                int B = Int32.Parse(b);
                return (A * B).ToString();
            }
            catch (Exception e)
            {
            }
            return "ERROR";
        }
        public string Division(string a, string b)
        {
            try
            {
                int A = Int32.Parse(a);
                int B = Int32.Parse(b);
                if (B != 0)
                {
                    return (A / B).ToString();
                }
                else
                {
                    return "divide by zero";
                }
            }
            catch (Exception e)
            {
            }
            return "ERROR";
        }
    }
}
