using SOLIDPrinciple.O;
using Xunit;
namespace CloudRMS.Test
{
    public class UnitTestO
    {
        [Fact]
        public void AreaCalculatorCircle_ReturnCorrectResult()
        {
            // Arrange  
            double expectedResult = 314;
            Shape shape = new Circle()
            {
                Radius = 10
            };

            // Act  
            var areaCalculator = new AreaCalculator();
            var actualResult = areaCalculator.GetArea(shape);
            //Assert  
            Assert.True(expectedResult.Equals(actualResult));

        }
        [Fact]
        public void AreaCalculatorRectangle_ReturnCorrectResult()
        {
            // Arrange  
            double expectedResult = 100;
            Shape shape = new Rectangle()
            {
                Width= 10,
                Height= 10
            };

            // Act  
            var areaCalculator = new AreaCalculator();
            var actualResult = areaCalculator.GetArea(shape);
            //Assert  
            Assert.True(expectedResult.Equals(actualResult));

        }
        [Fact]
        public void AreaCalculatorSquare_ReturnCorrectResult()
        {
            // Arrange  
            double expectedResult = 4;
            Shape shape = new Square()
            {
               side=2
            };

            // Act  
            var areaCalculator = new AreaCalculator();
            var actualResult = areaCalculator.GetArea(shape);
            //Assert  
            Assert.True(expectedResult.Equals(actualResult));

        }
    }
}
