using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_Adds_Given_Numbers()
        {
            var stringCalculator = new StringCalculator();
            Assert.Equal(1, stringCalculator.Add("1"));
        }
    }
}