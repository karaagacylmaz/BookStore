using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookStoreExternalServices
{
    public static class IsbnChecker
    {
        public static bool Check(string isbn)
        {
            string pattern = @"[0-9]";
            string input = isbn;
            var onlyNumbers = Regex.Replace(input, pattern, "");
            if (onlyNumbers.Length == 13)
            {
                return true;
            }
            return false;
        }
    }
}
