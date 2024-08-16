using Xunit;

namespace Sum2Nums_UnitTest
{
    public class BigNumberAdderTests
    {
        [Fact]
        public void HandlesLeadingZeros()
        {
            var adder = new BigNumberAdder();
            Assert.Equal("579", adder.Sum("0000123", "00000000000456"));
        }

        [Fact]
        public void HandlesBasicAddition()
        {
            var adder = new BigNumberAdder();
            Assert.Equal("200", adder.Sum("123", "77"));
        }

        [Fact]
        public void HandlesCarryOver()
        {
            var adder = new BigNumberAdder();
            Assert.Equal("1000", adder.Sum("999", "1"));
        }

        [Fact]
        public void HandlesZeroResult()
        {
            var adder = new BigNumberAdder();
            Assert.Equal("0", adder.Sum("0000", "0"));
        }

        [Fact]
        public void HandlesSameLengthNumbers()
        {
            var adder = new BigNumberAdder();
            Assert.Equal("1000", adder.Sum("500", "500"));
        }

        [Fact]
        public void HandlesLargeNumbers()
        {
            var adder = new BigNumberAdder();
            Assert.Equal("1000000000000000000", adder.Sum("999999999999999999", "1"));
        }

        [Fact]
        public void HandlesEmptyString()
        {
            var adder = new BigNumberAdder();
            Assert.Equal("12345", adder.Sum("", "12345"));
            Assert.Equal("54321", adder.Sum("54321", ""));
        }

    }

}