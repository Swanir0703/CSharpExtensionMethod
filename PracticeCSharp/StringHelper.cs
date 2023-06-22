using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp
{
    // Extension methods : When we want to add any new function to an existing Type ( like String is a Type ) ,
    // in that case we write extension method to achieve this.
    // the extension method must be static and 1st parameter must be of type this, this string input ..
    // the extension methods should be contained in a static class.
    // Other examples of extension methods are select, where functions of Enumerrable class which helps us write LINQ queries.

   public static class StringDemo
    {
        public static string ChangeCase(this string input)
        {
            if(input.Length >0)
            {
                char[] inputchar = input.ToCharArray();
                inputchar[0] = (char.IsUpper(inputchar[0]) ? char.ToLower(inputchar[0]) : char.ToUpper(inputchar[0]));
                return new string (inputchar);
            }
            return input;
        }

        public static string ChangeWordCase(this string input)
        {
            if(input.Length>0)
            {
                string newWord = string.Empty;
                char[] charinput = input.ToCharArray();
                foreach(char character in charinput)
                {
                   char tempChar= char.IsUpper(character) ? char.ToLower(character) : char.ToUpper(character);
                    newWord =string.Concat(newWord, tempChar.ToString());
                }
                return newWord;
            }
            return input;
        }
    }
}
