using System;
using System.Linq;

namespace ExternalApplication.Library;

public static class StringExtension
{
    public static string RemoveWhitespace(this string str)
    {
        return string.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
    }
}