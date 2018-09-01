using System;
using Xunit;

namespace BDSA2018.Assignment01.Tests {
	public partial class CalculatorTests {
		[Fact]
		public void Add_given_empty_string_returns_0() {
			var result = Calculator.Add("");
			Assert.Equal(0, result);
		}

		[Fact]
		public void Add_given_X_returns_Y() {
			var result = Calculator.Add("1");
			Assert.Equal(1, result);
		}

		[Fact]
		public void Add_given_XX_returns_Y() {
			var result = Calculator.Add("1,2");
			Assert.Equal(3, result);
		}

		[Fact]
		public void Add_given_negative_number_throws_exception() {
			Assert.Throws<ArgumentException>(() => Calculator.Add("-3"));
		}
	}
}
