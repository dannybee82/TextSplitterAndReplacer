using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TextSplitterAndReplacer.CommonMethods;

namespace TextSplitterAndReplacer.ApplicationMethods
{
    class SplitOrReplaceText
    {
        /// <summary>
        /// SplitText() - This method splits input at another string or Regular Expression.
        /// </summary>
        /// <param name="input">The string to split contents</param> 
        /// <param name="splitAt">The string to split the content at.</param>
        /// <param name="isRegex">When true, use a Regular Expression to split the content/input.</param>

        public string[] SplitText(string input, string splitAt, bool isRegex)
        {
            string[] lines = GetLines(input);

            List<string> output = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                string s = lines[i];

                string[] splitted;

                if (isRegex)
                {
                    splitted = Regex.Split(s, splitAt);
                }
                else
                {
                    splitted = s.Split(splitAt);
                }

                for (int j = 0; j < splitted.Length; j++)
                {
                    output.Add(splitted[j]);
                }
            }

            return output.ToArray();
        }

        /// <summary>
        /// ReplaceText() - This method replaces parts in a string using another string or Regular Expression.
        /// </summary>
        /// <param name="input">The string to replace its contents</param> 
        /// <param name="searchFor">The string to search for and replace</param>
        /// <param name="replace">Replace with this string</param>
        /// <param name="isRegex">>When true, use a Regular Expression to replace the content/input.</param>

        public string[] ReplaceText(string input, string searchFor, string replace, bool isRegex)
        {
            string[] lines = GetLines(input);

            for (int i = 0; i < lines.Length; i++)
            {
                string s = lines[i];

                if (isRegex)
                {
                    s = Regex.Replace(s, searchFor, replace);
                }
                else
                {
                    s = s.Replace(searchFor, replace);
                }

                lines[i] = s;
            }

            return lines;
        }

        /// <summary>
        /// IsValidRegex() - This method tests if the Regular Expression is valid.
        /// </summary>

        public bool IsValidRegex(string pattern)
        {
            if (string.IsNullOrWhiteSpace(pattern)) return false;

            try
            {
                Regex.Match("", pattern);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// GetLines() - Split string at linebreaks.
        /// </summary>

        private string[] GetLines(string s)
        {
            CommonStringMethods commonStringMethods = new();
            return commonStringMethods.SplitStringAtLineBreaks(s);
        }

    }

}