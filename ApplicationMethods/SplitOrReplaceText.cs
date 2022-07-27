using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TextSplitterAndReplacer.CommonMethods;

namespace TextSplitterAndReplacer.ApplicationMethods
{
    public class SplitOrReplaceText
    {
        /// <values>
        /// Properties.
        /// </values>

        private string? Input { get; set; }

        private string? SearchFor { get; set; }

        private string? Replace { get; set; }

        private string? SplitCharacter { get; set; }

        private bool IsRegex { get; set; }

        private string[]? Lines { get; set; }

        /// <summary>
        /// SplitText() - This method splits input at another string or Regular Expression.
        /// </summary>
        /// <param name="input">The string to split contents</param> 
        /// <param name="splitAt">The string to split the content at.</param>
        /// <param name="isRegex">When true, use a Regular Expression to split the content/input.</param>

        public string[] SplitText(string input, string splitAt, bool isRegex)
        {
            Input = input;
            SplitCharacter = splitAt;
            IsRegex = isRegex;           

            if ( (Input != null) && (SplitCharacter != null) )
            {
                GetLines();
            }

            //When using RegEx -> Then test it. When not using Regex, return true;
            bool testWhenUsingRegex = (IsRegex) ? IsValidRegex(SplitCharacter) : true;

            if ((Lines != null) && testWhenUsingRegex)
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
        /// <param name="searchFor">The string to search for and replace</param>
        /// <param name="replace">Replace with this string</param>
        /// <param name="isRegex">>When true, use a Regular Expression to replace the content/input.</param>

        public string[] ReplaceText(string input, string searchFor, string replace, bool isRegex)
        {
            Input = input;
            SearchFor = searchFor;
            Replace = replace;
            IsRegex = isRegex;

            if ((Input != null) && (SearchFor != null) && (Replace != null))
            {
                GetLines();
            }

            //When using RegEx -> Then test it. When not using Regex, return true;
            bool testWhenUsingRegex = (IsRegex) ? IsValidRegex(SearchFor) : true;

            if (Lines != null && testWhenUsingRegex)
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
                string s = Lines[i];

                string[] splitted;

                if (IsRegex)
                {
                    splitted = Regex.Split(s, SplitCharacter);
                }
                else
                {
                    splitted = s.Split(SplitCharacter);
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

                if (IsRegex)
                {
                    s = Regex.Replace(s, SearchFor, Replace);
                }
                else
                {
                    s = s.Replace(SearchFor, Replace);
                }

                Lines[i] = s;
            }
        }

        /// <summary>
        /// IsValidRegex() - This method tests if the Regular Expression is valid.
        /// </summary>

        public bool IsValidRegex(string pattern)
        {
            CommonStringMethods commonStringMethods = new();

            if (commonStringMethods.IsStringNullOrWhiteSpace(pattern)) return false;

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
            CommonStringMethods commonStringMethods = new();

            if (commonStringMethods.IsStringNullOrEmpty(this.Input))
            {
                this.Lines = null;
            } else
            {
                this.Lines = commonStringMethods.SplitStringAtLineBreaks(this.Input);
            }            
        }

    }

}