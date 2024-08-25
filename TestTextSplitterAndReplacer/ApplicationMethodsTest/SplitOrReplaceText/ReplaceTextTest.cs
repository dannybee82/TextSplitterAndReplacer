using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSplitterAndReplacer.ApplicationMethods;

namespace TestTextSplitterAndReplacer.ApplicationMethodsTest.SplitOrReplaceTextTest
{
    public class ReplaceTextTest : SplitOrReplaceText
    {

        [Theory]
        [InlineData(
            null,
            null,
            null,
            false,
            null
        )]
        [InlineData(
            "A Test String",
            null,
            null,
            false,
            null
        )]
        [InlineData(
            "A Test String",
            "String",
            null,
            false,
            null
        )]
        [InlineData(
            "A Test String",
            null,
            "[String]",
            true,
            null
        )]
        [InlineData(
            "A Test String",
            "String",
            "[String Replaced]",
            false,
            new string[] 
            { 
                "A Test [String Replaced]"
            }
        )]
        [InlineData(
            "A Test String\nA Test String\nA Test String",
            "String",
            "[String Replaced]",
            false,
            new string[]
            {
                "A Test [String Replaced]",
                "A Test [String Replaced]",
                "A Test [String Replaced]",
            }
        )]
        [InlineData(
            "A Test String",
             @"\s",
            "|",
            true,
            new string[]
            {
                "A|Test|String",
            }
        )]
        [InlineData(
            "A Test String 1: one\nA Test String 2: two\nA Test String 3: three",
             @"\d",
           "[NUMBER]",
            true,
            new string[]
            {
                "A Test String [NUMBER]: one",
                "A Test String [NUMBER]: two",
                "A Test String [NUMBER]: three"
            }
        )]
        public void Test_ReplaceText(string input, string searchForString, string replaceString, bool useRegex, string[] expectedResult)
        {
            //Arrange + Act
            string[] result = ReplaceText(input, searchForString, replaceString, useRegex);

            //Assert
            Assert.Equal(expectedResult, result);
        }


    }

}