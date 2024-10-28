namespace fix_bugs_2_string_calculator;

public class StringCalculatorTests
{
    public class HappyPath
    {
        [Fact]
        public void Add_SingleNumber_ReturnsSameNumber()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("5");
            Assert.Equal("5", result);
        }

        [Fact]
        public void Add_TwoNumbersSeparatedByComma_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.Equal("3", result);
        }

        [Fact]
        public void Add_MultipleNumbersSeparatedByComma_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4");
            Assert.Equal("10", result);
        }

        [Fact]
        public void Add_NumbersSeparatedByNewline_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1\n2\n3");
            Assert.Equal("6", result);
        }

        [Fact]
        public void Add_CustomDelimiter_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("//;\n1;2");
            Assert.Equal("3", result);
        }
    }

    public class EdgeCases
    {

    }
}