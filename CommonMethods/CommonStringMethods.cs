using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TextSplitterAndReplacer.CommonMethods
{
    /// <summary>
    /// CommonStringMethods - This class contains common string methods.
    /// </summary>

    public class CommonStringMethods
    {

        /// <summary>
        /// GetIndexFromString() - Searches for a string from Left to Right.
        /// </summary>
        public int GetIndexFromString(string s, string search)
        {
            return s.IndexOf(search);
        }

        /// <summary>
        /// GetLastIndexFromString() - Searches for a string from Right to Left;
        /// </summary>
        public int GetLastIndexFromString(string s, string search)
        {
            return s.LastIndexOf(search);
        }

        /// <summary>
        /// GetIndexOfChar()
        /// </summary>

        public int GetIndexOfChar(string s, char[] c)
        {
            return s.IndexOfAny(c);
        }

        /// <summary>
        /// GetLastIndexOfChar()
        /// </summary>

        public int GetLastIndexOfChar(string s, char[] c)
        {
            return s.LastIndexOfAny(c);
        }

        /// <summary>
        /// StringContains()
        /// </summary>

        public bool StringContains(string s, string search)
        {
            if (GetIndexFromString(s, search) > -1)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// StringContainsAlternative()
        /// </summary>
        public bool StringContainsAlternative(string s, string search)
        {
            return s.Contains(search);
        }

        /// <summary>
        /// StringContainsCharacter()
        /// </summary>

        public bool StringContainsCharacter(string s, char c)
        {
            return s.Contains(c);
        }

        /// <summary>
        /// GetPartFromString() - This method uses Substring(int from, int length)
        /// </summary>

        public string GetPartFromString(string s, int from, int length)
        {
            return s.Substring(from, length);
        }

        /// <summary>
        /// GetPartFromStringWithRanges() - This method uses the 'hat' en 'range' operators to get a part from a string.
        /// Here start-index 0 is ommitted.
        /// </summary>
        /// <param name="s">subject string</param>
        /// <param name="to">int to = the end index. In this method the start-index 0 can be ommitted.</param>

        public string GetPartFromStringWithRanges(string s, int to)
        {
            return s[..to];
        }

        /// <summary>
        /// GetPartFromStringWithRanges() - This method uses the 'hat' en 'range' operators to get a part from a string.
        /// </summary>
        /// <param name="s">
        /// string s = subject
        /// </param>
        /// <param name="from">
        /// int from = the start index.
        /// </param>
        /// <param name="to">
        /// int to = the end index.
        /// </param>

        public string GetPartFromStringWithRanges(string s, int from, int to)
        {
            return s[from..to];
        }

        /// <summary>
        /// GetPartFromStringWithRangesFromEnd() - This method uses the 'hat' en 'range' operators to get a part from a string from the end.
        /// e.g. the sentence:
        /// Just another test
        /// -> to get the word test, use:
        /// GetPartFromStringWithRangesFromEnd("Just another test", 0, 4); //Starts at the end, 0 at the end is the first index.
        /// This method uses ^for inversion.
        /// </summary>
        /// <param name="s">
        /// string s = subject
        /// </param>
        /// <param name="from">
        /// int from = the start index.
        /// </param>
        /// <param name="to">
        /// int to = the end index.
        /// </param>

        public string GetPartFromStringWithRangesFromEnd(string s, int from, int to)
        {
            return s[^to..^from];
        }

        /// <summary>
        /// GetPartBeforeCharacter() - Get all string characters before the endIndex.
        /// </summary>
        private string GetPartBeforeString(string s, string character, int amountOfCharacters)
        {
            int pos = s.IndexOf(character);

            if (pos > -1)
            {
                return s.Substring(0, amountOfCharacters);
            }


            return s;
        }

        /// <summary>
        /// TestStringStartsWith()
        /// </summary>
        public bool TestStringStartsWith(string s, string test)
        {
            return s.StartsWith(test);
        }

        /// <summary>
        /// TestStringStartsWith() - Overloaded method.
        /// </summary>
        public bool TestStringStartsWith(string s, char test)
        {
            return s.StartsWith(test);
        }

        /// <summary>
        /// TestStringStartsWith()
        /// </summary>
        public bool TestStringStartsWith(string s, string[] test)
        {
            foreach (string i in test)
            {
                if (s.StartsWith(i))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// TestStringStartsWith()
        /// </summary>
        public bool TestStringStartsWith(string s, char[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                if (s.StartsWith(test[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// TestStringEndsWith()
        /// </summary>
        public bool TestStringEndsWith(string s, string test)
        {
            return s.EndsWith(test);
        }

        /// <summary>
        /// TestStringEndsWith() - Overloaded method.
        /// </summary>
        public bool TestStringEndsWith(string s, char test)
        {
            return s.EndsWith(test);
        }

        /// <summary>
        /// TestStringEndsWith()
        /// </summary>
        public bool TestStringEndsWith(string s, string[] test)
        {
            foreach (string i in test)
            {
                if (s.EndsWith(i))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// TestStringEndsWith()
        /// </summary>
        public bool TestStringEndsWith(string s, char[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                if (s.EndsWith(test[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// StringHasLettersAndNumbersOnly()
        /// </summary>

        public bool StringHasLettersAndNumbersOnly(string s)
        {
            return Regex.IsMatch(s.ToLower(), pattern: "^[\\w\\d]*$");
        }

        /// <summary>
        /// TestStringWithRegEx()
        /// </summary>
        public bool TestStringWithRegEx(string s, string regex)
        {
            return Regex.IsMatch(s, pattern: regex);
        }

        /// <summary>
        /// CountCharacterInString()
        /// </summary>
        public int CountCharacterInString(string s, string search)
        {
            int count = 0;

            foreach (char i in s)
            {
                if (i.Equals(search))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// CountCharacterInString()
        /// </summary>
        public int CountCharacterInString(string s, char search)
        {
            int count = 0;

            foreach (char i in s)
            {
                if (i.Equals(search))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// CountLowerCaseLetters()
        /// </summary>
        public int CountLowerCaseLetters(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i])) count++;
            }

            return count;
        }

        /// <summary>
        /// CountUpperCaseLetters()
        /// </summary>
        public int CountUpperCaseLetters(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) count++;
            }

            return count;
        }

        /// <summary>
        /// SplitStringAtLineBreaks() : This method splits a String at line breaks, such as: \\r?\\n
        /// </summary>

        public string[] SplitStringAtLineBreaks(string s)
        {
            return s.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        }

        /// <summary>
        /// ReverseStringAlternative() - Alternative method to reverse a string.
        /// </summary>
        public string ReverseStringAlternative(string s)
        {
            string reversed = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed = string.Concat(reversed, s[i]);
            }

            return reversed;
        }

        /// <summary>
        /// ReverseString() - More effective method to reverse string.
        /// </summary>
        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                char c = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = c;
            }

            return new string(arr);
        }

        /// <summary>
        /// TestEmptyString()
        /// </summary>
        public bool TestEmptyString(string s)
        {
            if (s.Equals(""))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// IsStringNullOrWhiteSpace()
        /// </summary>
        public bool IsStringNullOrWhiteSpace(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        /// <summary>
        /// IsStringNullOrEmpty()
        /// </summary>

        public bool IsStringNullOrEmpty(string s)
        {
            return string.IsNullOrEmpty(s);
        }

        /// <summary>
        /// TrimStartOfString()
        /// </summary>

        public string TrimStartOfString(string s)
        {
            return s.TrimStart();
        }

        /// <summary>
        /// TrimEndOfString()
        /// </summary>

        public string TrimEndOfString(string s)
        {
            return s.TrimEnd();
        }

        /// <summary>
        /// TrimString()
        /// </summary>

        public string TrimString(string s)
        {
            return s.Trim();
        }

        /// <summary>
        /// TrimCharactersAtStartOfString()
        /// </summary>

        public string TrimCharactersAtStartOfString(string s, char c)
        {
            return s.TrimStart(c);
        }

        /// <summary>
        /// TrimCharactersAtStartOfString()
        /// </summary>

        public string TrimCharactersAtStartOfString(string s, char[] c)
        {
            return s.TrimStart(c);
        }

        /// <summary>
        /// TrimCharactersAtEndOfString()
        /// </summary>
        public string TrimCharactersAtEndOfString(string s, char c)
        {
            return s.TrimEnd(c);
        }

        /// <summary>
        /// TrimCharactersAtEndOfString()
        /// </summary>

        public string TrimCharactersAtEndOfString(string s, char[] c)
        {
            return s.TrimEnd(c);
        }

        /// <summary>
        /// TrimCharactersFromString()
        /// </summary>

        public string TrimCharactersFromString(string s, char c)
        {
            return s.Trim(c);
        }

        /// <summary>
        /// TrimCharactersFromString()
        /// </summary>

        public string TrimCharactersFromString(string s, char[] c)
        {
            return s.Trim(c);
        }

        /// <summary>
        /// AddPaddingLeftToString()
        /// </summary>
        public string AddPaddingLeftToString(string s, int totalWidth)
        {
            return s.PadLeft(totalWidth);
        }

        /// <summary>
        /// AddPaddingLeftToString()
        /// </summary>
        public string AddPaddingLeftToString(string s, int totalWidth, char c)
        {
            return s.PadLeft(totalWidth, c);
        }

        /// <summary>
        /// AddPaddingRightToString()
        /// </summary>
        public string AddPaddingRightToString(string s, int totalWidth)
        {
            return s.PadRight(totalWidth);
        }

        /// <summary>
        /// AddPaddingRightToString()
        /// </summary>
        public string AddPaddingRightToString(string s, int totalWidth, char c)
        {
            return s.PadRight(totalWidth, c);
        }

        /// <summary>
        /// ConcatenateStrings() - Concatenate strings, without separator.
        /// </summary>

        public string ConcatenateStrings(string s1, string s2)
        {
            return string.Concat(s1, s2);
        }

        /// <summary>
        /// ConcatenateStrings() - Concatenate strings, without separator.
        /// </summary>

        public string ConcatenateStrings(string[] arr)
        {
            return string.Concat(arr);
        }

        /// <summary>
        /// JoinStrings() - Concatenate strings using a separator.
        /// </summary>
        /// <param>
        /// @param c = separator char.
        /// </param>

        public string JoinStrings(char c, string[] arr)
        {
            return string.Join(c, arr);
        }

        /// <summary>
        /// JoinStrings() - Concatenate strings using a separator.
        /// </summary>

        public string JoinStrings(string separator, string[] arr)
        {
            return string.Join(separator, arr);
        }

        /// <summary>
        /// CompareStringsAlfabetically()
        /// </summary>
        /// <returns>
        /// @return int : -1 = before, 0 = equal, 1 = after
        /// </returns>
        public int CompareStringsAlfabetically(string s1, string s2)
        {
            return string.Compare(s1, s2);
        }

        /// <summary>
        /// CompareStringsAlfabeticallyAlt() - Alternative method.
        /// </summary>
        /// <returns>
        /// @return int : -1 = before, 0 = equal, 1 = after
        /// </returns>

        public int CompareStringsAlfabeticallyAlt(string s1, string s2)
        {
            return s1.CompareTo(s2);
        }

        /// <summary>
        /// CopyToString() - 'Deep copy' (uses another memory location) of string.
        /// To convert char[] to String use: new String(char[] arr)
        /// </summary>
        /// <returns>
        /// @return byte[] arr;
        /// </returns>

        public char[] CopyToString(string s, int sourceIndex, int length)
        {
            char[] arr = new char[length];
            //Below: use 0 to match the array.
            s.CopyTo(sourceIndex, arr, 0, length);
            return arr;
        }

        /// <summary>
        /// RemoveIndexesFromString() - Usefull to remove all strings after the startIndex.
        /// </summary>
        public string RemoveIndexesFromString(string s, int startIndex)
        {
            return s.Remove(startIndex);
        }

        /// <summary>
        /// RemoveIndexesFromString()  - Usefull to remove all strings after the startIndex.
        /// </summary>
        public string RemoveIndexesFromString(string s, int startIndex, int amountToRemove)
        {
            if (amountToRemove > 0)
            {
                return s.Remove(startIndex, amountToRemove);
            }

            return s;
        }

        /// <summary>
        /// GetPartBeforeString() - Get all string characters before the endIndex.
        /// </summary>
        public string GetPartBeforeString(string s, int amountOfCharacters)
        {
            return s.Substring(0, amountOfCharacters);
        }

        /// <summary>
        /// InsertIntoString()
        /// </summary>

        public string InsertIntoString(string s, int index, string insert)
        {
            return s.Insert(index, insert);
        }

        /// <summary>
        /// ReplacePartFromString() - Replaces all occurrences of: search by: replace
        /// </summary>
        public string ReplacePartFromString(string s, string search, string replace)
        {
            return s.Replace(search, replace);
        }

        /// <summary>
        /// ReplaceAllPartsFromString() - Replaces all occurrences of: string[] search by: replace
        /// </summary>

        public string ReplaceAllPartsFromString(string s, string[] search, string replace)
        {
            foreach (string text in search)
            {
                while (GetIndexFromString(s, text) > -1)
                {
                    s = ReplacePartFromString(s, text, replace);
                }
            }

            return s;
        }

        /// <summary>
        /// CapitalizeFirstLetter()
        /// </summary>

        public string CapitalizeFirstLetter(string s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);

            return new string(a);
        }

        /// <summary>
        /// UpperCaseFirstCharacter() - Alternative method for: CapitalizeFirstLetter().
        /// </summary>

        public string UpperCaseFirstCharacter(string s)
        {
            return Regex.Replace(s, "^[a-z]", m => m.Value.ToUpper());
        }

        /// <summary>
        /// StripAccentsFromString() - Remove accents/special characters from a string. e.g. mäny àccénts ïñ â strïng -> many accents in a string
        /// </summary>
        /// <param name="s">
        /// string s = a string with special characters that need to be stripped/removed.        /// 
        /// </param>
        /// <returns>
        /// return string = a string with stripped/removed special characters.
        /// </returns>

        public string StripAccentsFromString(string s)
        {
            //Set provider for text codes.
            EncodingProvider provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            byte[] tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(s);
            return Encoding.UTF8.GetString(tempBytes);
        }

    }
}
