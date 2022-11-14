using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TESTTTT;

namespace TESTTTTTest
{
    public class UnitTest
    {
        public UnitTest()
        {
            [Theory]
            [InlineData(2, 2, 4)]
            void Add(int num1, int num2, int expected)
            {
                //Arrange
                Addition tester = new Addition();

                //Act
                var actual = tester.Add(num1, num2);

                //Assert
                Assert.Equal(expected, actual); 

            }



        }
    }
}
