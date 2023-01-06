using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (String.IsNullOrWhiteSpace(input) || input.Length == 0) return true;
            else return false;
        }

        public static string MixString(string a, string b)
        {
            string result = "";
            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                if (i >= a.Length) result += a.Substring(i - 1);
                if (i >= b.Length) result += b.Substring(i - 1);
                if (a.Substring(i,1) != null) result += a[i];
                if (b.Substring(i,1) != null) result += b[i];
            }
            return result;
        }
    }
}
