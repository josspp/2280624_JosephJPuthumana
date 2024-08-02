using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class StringvsStringBuilder
    {
        static void Main8(string[] args)
        {
            string s = string.Empty;
            s = "malayalam";
            s.ToUpper();
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            //sb.Clear();
            Console.WriteLine(sb.ToString());

            string palindrom = "";
            for (int i = 0,j=s.Length; i < j; i++,j--)
            {
                Console.WriteLine(s[i] +":"+s[j-1]);
                if (s[i] == s[j-1])
                {
                    palindrom = "True";
                    break;
                    //Console.WriteLine("Palindrome=" + palindrom);
                }
                else
                {
                    palindrom = "False";
                    break;
                    //Console.WriteLine("Palindrome=" + palindrom);
                }
            }
            Console.WriteLine("Palindrome="+ palindrom);
        }
    }
}