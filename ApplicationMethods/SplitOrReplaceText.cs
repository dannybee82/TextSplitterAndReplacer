using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TextSplitterAndReplacer.CommonMethods;

namespace TextSplitterAndReplacer.ApplicationMethods
{
    /// <summary>
    /// SplitOrReplaceText - This class contains methods to Split and Replace Text.
    /// </summary>

    public class SplitOrReplaceText
    {
        /// <values>
        /// Properties.
        /// </values>

        #nullable enable
        private string? Input { get; set; }

        private string? SearchForString { get; set; }

        private string? ReplaceString { get; set; }

        private string? SplitAtString { get; set; }

        private string[]? Lines { get; set; }
        #nullable disable

        private bool UseRegex { get; set; }

        /// <values>
        /// 
        /// </values>

        private CommonStringMethods commonStringMethods = new();

        /// <summary>
        /// SplitText() - This method splits input at another string or Regular Expression.
        /// </summary>
        /// <param name="input">The string to split contents</param> 
        /// <param name="splitAtString">The string to split the content at.</param>
        /// <param name="useRegex">When true, use a Regular Expression (splitAtString) to split the content/input.</param>

        public string[] SplitText(string input, string splitAtString, bool useRegex)
        {
            Input = input;
            SplitAtString = splitAtString;
            UseRegex = useRegex;

            if ((Input != null) && (SplitAtString != null))
            {
                GetLines();
            }

            //When using RegEx -> Then test the RegEx. When not using Regex, return true;
            bool testRegExValidity = (UseRegex) ? IsValidRegex(SplitAtString) : true;

            if ((Lines != null) && testRegExValidity)
            {
                ExecuteSplit();
            }
            else
            {
                Lines = null;
            }

            return Lines;
        }

        /// <summary>
        /// ReplaceText() - This method replaces parts in a string using another string or Regular Expression.
        /// </summary>
        /// <param name="input">The string to replace its contents</param> 
        /// <param name="searchForString">The string to search for and replace</param>
        /// <param name="replaceString">Replace with this string</param>
        /// <param name="useRegex">>When true, use a Regular Expression (searchForString) to replace the content/input.</param>

        public string[] ReplaceText(string input, string searchForString, string replaceString, bool useRegex)
        {
            Input = input;
            SearchForString = searchForString;
            ReplaceString = replaceString;
            UseRegex = useRegex;

            if ((Input != null) && (SearchForString != null) && (ReplaceString != null))
            {
                GetLines();
            }

            //When using RegEx -> Then test the RegEx. When not using Regex, return true;
            bool testRegExValidity = UseRegex ? IsValidRegex(SearchForString) : true;

            if ((Lines != null) && testRegExValidity)
            {
                ExecuteReplacement();
            }
            else
            {
                Lines = null;
            }

            return Lines;
        }

        /// <summary>
        /// ExecuteSplit() - Method executing the split method.
        /// </summary>
        /// <returns></returns>

        private void ExecuteSplit()
        {
            List<string> output = new List<string>();

            for (int i = 0; i < Lines.Length; i++)
            {
                string[] splitted;

                if (UseRegex)
                {
                    splitted = Regex.Split(Lines[i], SplitAtString);
                }
                else
                {
                    splitted = Lines[i].Split(SplitAtString);
                }

                for (int j = 0; j < splitted.Length; j++)
                {
                    output.Add(splitted[j]);
                }
            }

            Lines = output.ToArray();
        }

        /// <summary>
        /// ExecuteReplacement() - This method executes replacement in Lines.
        /// </summary>

        private void ExecuteReplacement()
        {
            for (int i = 0; i < Lines.Length; i++)
            {
                string s = Lines[i];

                if (UseRegex)
                {
                    s = Regex.Replace(s, SearchForString, ReplaceString);
                }
                else
                {
                    s = s.Replace(SearchForString, ReplaceString);
                }

                Lines[i] = s;
            }
        }

        /// <summary>
        /// IsValidRegex() - This method tests if the Regular Expression is valid.
        /// </summary>

        public bool IsValidRegex(string pattern)
        {
            if (commonStringMethods.IsStringNullOrWhiteSpace(pattern))
            {
                return false;
            }

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

        private void GetLines()
        {
            Lines = commonStringMethods.SplitStringAtLineBreaks(Input);
        }
    }
}