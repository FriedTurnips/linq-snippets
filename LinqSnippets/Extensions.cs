using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSnippets
{
    static class Extensions
    {
        public static string UpperCaseFirstCharacter(this String value)
        {
            char[] charArray = value.ToCharArray();
            var firstChar = charArray[0].ToString().ToUpper();
            charArray[0] = Convert.ToChar(firstChar);
            return new string(charArray);
        }
    }
}
