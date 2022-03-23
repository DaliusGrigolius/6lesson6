using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_advanced_1_palindromas
{
    internal class Palindromizer
    {
        public bool IsPalindrome(string str)
        {
            string st = "";
            foreach (char chr in str.ToLower())
            {
                if (char.IsLetter(chr) != char.IsDigit(chr))
                {
                    st += chr;
                }
            }
            // ignore the period, space and other char except alphabets

            char[] ch = st.ToCharArray();
            Array.Reverse(ch);
            
            string rev = new string(ch);
            
            return st == rev;
        }
    }
}
