using SOLIDPrinciple.L;
using SOLIDPrinciple.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CloudRMS.Test
{
    public class UnitTestL
    {
        [Fact]
        public void TestForBMW()
        {
            // Arrange  
            var expectedResult = "RED";
           Car bmw= new BMW();
            // Act  
            var actualResult = bmw.GetColor();
            //Assert  
            Assert.True(expectedResult.Equals(actualResult));

        }
        [Fact]
        public void TestForTOYATA()
        {
            // Arrange  
            var expectedResult = "BLUE";
            Car toyata = new Toyota();
            // Act  
            var actualResult = toyata.GetColor();
            //Assert  
            Assert.True(expectedResult.Equals(actualResult));

        }
    }
}
