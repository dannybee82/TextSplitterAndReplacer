using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSplitterAndReplacer.ApplicationMethods;

namespace TestTextSplitterAndReplacer.ApplicationMethodsTest.SplitOrReplaceTextTest
{
    public class IsValidRegexTest : SplitOrReplaceText
    {

        [Theory]
        [InlineData(
            null,
            false
        )]
        [InlineData(
            "",
            false
        )]
        [InlineData(
            " ",
            false
        )]
        [InlineData(
            @"[\d[{1{",
            false
        )]
        [InlineData(
            @"^.*\d.*$",
            true
        )]
        [InlineData(
            @"^.*\w.*$",
            true
        )]
        [InlineData(
            @"^Test",
            true
        )]
        [InlineData(
            @"End$",
            true
        )]
        public void Test_IsValidRegex(string pattern, bool expectedResult)
        {
            //Arrange + Act
            bool result = IsValidRegex(pattern);

            //Assert
            Assert.Equal(expectedResult, result);
        }


    }

}