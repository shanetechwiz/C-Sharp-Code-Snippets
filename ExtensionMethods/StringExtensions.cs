using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string UppercaseWords(this string value)
        {
            if (value == null)
                return string.Empty;

            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i - 1] != ' ') continue;
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            return new string(array);
        }
    }
}
