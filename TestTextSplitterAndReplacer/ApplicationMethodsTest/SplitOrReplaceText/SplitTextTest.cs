using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSplitterAndReplacer.ApplicationMethods;

namespace TestTextSplitterAndReplacer.ApplicationMethodsTest.SplitOrReplaceTextTest
{
    public class SplitTextTest : SplitOrReplaceText
    {

        [Theory]
        [InlineData(
            null,
            null,
            false,
            null
        )]
        [InlineData(
            "A Test String",
            null,
            false,
            null
        )]
        [InlineData(
            null,
            null,
            true,
            null
        )]
        [InlineData(
            "A Test String",
            null,
            true,
            null
        )]
        [InlineData(
            "A Test String",
            " ",
            false,
            new string[] 
            { 
                "A",
                "Test",
                "String"
            }
        )]
        [InlineData(
            "A Test String",
            @"\s",
            true,
            new string[]
            {
                "A",
                "Test",
                "String"
            }
        )]
        [InlineData(
            "A Test String",
            @"[\s[",
            true,
            null
        )]

        public void Test_SplitText(string input, string splitAtString, bool useRegex, string[] expectedResult)
        {
            //Arrange + Act
            string[] result = SplitText(input, splitAtString, useRegex);

            //Assert
            Assert.Equal(expectedResult, result);
        }


    }

}