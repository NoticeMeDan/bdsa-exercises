using Xunit;

namespace BDSA2018.Assignment01.Tests {
	public partial class CalculatorTests {
		[Fact]
		public void Magnitude_given_1764_returns_4() {
			var actual = Calculator.Magnitude("1764");

			Assert.Equal(4, actual);
		}

		[Fact]
		public void Magnitude_given_42_returns_true() {
			var actual = Calculator.Magnitude("42");

			Assert.Equal(2, actual);
		}

		[Theory]
		[InlineData("-42", 2)]
		[InlineData("0", 1)]
		[InlineData("256", 3)]
		[InlineData("10000", 5)]
		[InlineData("9223372036854775807", 19)]
		public void Magnitude_given_number_returns_expected(string number, int expected) {
			var actual = Calculator.Magnitude(number);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Magnitude_given_invalid_number_returns_minus_1() {
			var actual = Calculator.Magnitude("goofy");

			Assert.Equal(-1, actual);
		}
	}
}
