using System;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {

        public static bool IsSecure(this Uri uri)
        {
            return uri.Scheme == "https";
        }
        public static int WordCount(this string sentence)
        {
            Regex exp = new Regex("(\\p{L}\\p{M}*)+");
            return exp.Matches(sentence).Count;
        }

    }
}
