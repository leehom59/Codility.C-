using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geekors.Codility.Lession7
{
    /// <summary>
    /// https://codility.com/programmers/task/nesting/
    /// Determine whether given string of parentheses is properly nested.
    /// </summary>
    public class Nesting
    {
        public int solution(string S)
        {
            int prefixCount = 0; int postfixCount = 0;
            foreach (char chChrt in S)
            {
                if (chChrt == '(') prefixCount++;
                if (chChrt == ')')
                {
                    postfixCount++;
                    if (postfixCount > prefixCount) return 0;
                }
            }

            return prefixCount == postfixCount ? 1 : 0;
        }
    }
}
