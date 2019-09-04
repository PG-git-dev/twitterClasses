using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClasses
{
    public static class StringHelper
    {
        public static string Cut(string text, int lim)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            if (text.Length <= lim-1)
                return text;
            else
                return text.Remove(lim);
        }
    }
}
