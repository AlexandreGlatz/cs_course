using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string? input)
        {
            if (input == null)
                return true;

            if (input.Length == 0)
                return true;

            int i = 0;
            while (input[i] == ' ' && i < input.Length - 1)
                i++;

            return input.Length == i + 1;
        }

        public static string MixString(string s, string s1)
        {
            if (IsNullEmptyOrWhiteSpace(s) || IsNullEmptyOrWhiteSpace(s1)) throw new ArgumentException();

            string result = "";
            for (int i = 0; i < s.Length + s1.Length; i++)
            {
                if (i + s.Length > s.Length + s1.Length)
                    result += s[i];
                
                else if (i > s.Length)
                    result += s1[i];

                else
                    result += s1[i] + s[i];
            }

            return result;
        }

        public static string ToLowerCase(string s)
        {
            throw new NotImplementedException();
        }

        public static string Voyelles(string s)
        {
            throw new NotImplementedException();
        }

        public static string Reverse(string s)
        {
            throw new NotImplementedException();
        }

        public static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
